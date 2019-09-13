namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftCount
{
  using MediatR;
  using Nethereum.Contracts;
  using P9Control.Server.Services.WebThree.Contracts.NftCreator.ContractInstance;
  using P9Control.Api.Constants.AccountAddresses;
  using System.Threading;
  using System.Threading.Tasks;

  public class GetNftCountServerServiceHandler : IRequestHandler<GetNftCountServiceRequest, GetNftCountServiceResponse>
  {
    private NftCreatorInstance NftCreatorInstance { get; set; }

    public GetNftCountServerServiceHandler(NftCreatorInstance aNftCreatorInstance)
    {
      NftCreatorInstance = aNftCreatorInstance;
    }

    public async Task<GetNftCountServiceResponse> Handle(GetNftCountServiceRequest aGetNftTypesServiceRequest, CancellationToken aCancellationToken)
    {
      //Function<GetNftCountServiceRequest> totalNftsFunction = NftCreatorInstance.Instance.GetFunction<GetNftCountServiceRequest>();

      Function totalNftsFunction = NftCreatorInstance.Instance.GetFunction("totalNFTs");

      uint NftCount = await totalNftsFunction.CallAsync<uint>();

      return new GetNftCountServiceResponse()
      {
        NftCount = NftCount
      };

    }
  }
}