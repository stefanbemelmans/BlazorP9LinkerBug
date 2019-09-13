namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.MintNftOfType
{
  using Nethereum.Hex.HexTypes;
  using P9Control.Api.Features.Base;

  public class MintNftOfTypeServiceResponse : BaseResponse
  {
    // No response for this function but an Event is emitted
    // This is trying to capture the event Data
    // The Transaction Receipt is good for now as if succesful the new token will be visible in State/UI

    public int TokenId { get; set; }
    public string TransactionHash { get; set; }
    public HexBigInteger GasUsed { get; set; }
  }
}