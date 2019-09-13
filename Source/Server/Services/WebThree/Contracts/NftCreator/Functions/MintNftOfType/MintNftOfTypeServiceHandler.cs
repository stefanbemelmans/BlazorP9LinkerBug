namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.MintNftOfType
{
  using MediatR;
  using Nethereum.Contracts;
  using Nethereum.Hex.HexTypes;
  using P9Control.Server.Services.WebThree.Contracts.Herc1155;
  using P9Control.Server.Services.WebThree.Contracts.NftCreator.ContractInstance;
  using P9Control.Server.Services.WebThree.Instance;
  using P9Control.Api.Constants.ContractConstants.NftCreator;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType;
  using System.Numerics;
  using System.Threading;
  using System.Threading.Tasks;

  public class MintNftOfTypeServerServiceHandler : IRequestHandler<MintNftOfTypeServiceRequest, MintNftOfTypeServiceResponse>
  {
    private NethWeb3 NethWeb3 { get; set; }
    private NftCreatorInstance NftCreatorInstance { get; set; }

    public MintNftOfTypeServerServiceHandler(NethWeb3 aNethWeb3, NftCreatorInstance aNftCreatorInstance)
    {
      NftCreatorInstance = aNftCreatorInstance;
      NethWeb3 = aNethWeb3;
    }

    public async Task<MintNftOfTypeServiceResponse> Handle(MintNftOfTypeServiceRequest aMintNftOfTypeServiceRequest, CancellationToken aCancellationToken)
    {
      Function<MintNftOfTypeFunctionInput> aMintNftOfTypeFunction = NftCreatorInstance.Instance.GetFunction<MintNftOfTypeFunctionInput>();

      Nethereum.Contracts.ContractHandlers.IContractTransactionHandler<MintNftOfTypeFunctionInput> mintingHandler = NethWeb3.Instance.Eth.GetContractTransactionHandler<MintNftOfTypeFunctionInput>();
      // serialization needed

      var aMintNftOfTypeFunctionMessage = new MintNftOfTypeFunctionInput
      {
        NftId = aMintNftOfTypeServiceRequest.MintNftId,
        ImmutableDataString = aMintNftOfTypeServiceRequest.ImmutableDataString,
        MutableDataString = aMintNftOfTypeServiceRequest.MutableDataString == null ? "" : aMintNftOfTypeServiceRequest.MutableDataString
      };

      Nethereum.Hex.HexTypes.HexBigInteger gasEstimate = await mintingHandler.EstimateGasAsync(NftCreatorAddresses.NewNftCreatorRopstenAddress, aMintNftOfTypeFunctionMessage);

      aMintNftOfTypeFunctionMessage.Gas = gasEstimate.Value;

      Nethereum.RPC.Eth.DTOs.TransactionReceipt mintingTransactionReceipt = await mintingHandler.SendRequestAndWaitForReceiptAsync(NftCreatorAddresses.NewNftCreatorRopstenAddress, aMintNftOfTypeFunctionMessage);

      System.Collections.Generic.List<EventLog<MintNftOutputEventDto>> MintNftOutput = mintingTransactionReceipt.DecodeAllEvents<MintNftOutputEventDto>();

      int id = (int)MintNftOutput[0].Event.Id;
      return new MintNftOfTypeServiceResponse
      {
        TransactionHash = mintingTransactionReceipt.TransactionHash,
        TokenId = id,
        GasUsed = new HexBigInteger(mintingTransactionReceipt.GasUsed.Value)
      };
    }
  }
}