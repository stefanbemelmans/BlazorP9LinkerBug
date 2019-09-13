namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftCount
{
  using Nethereum.ABI.FunctionEncoding.Attributes;

  [FunctionOutput]
  public class GetNftCountServiceResponse : IFunctionOutputDTO
  {
    public uint NftCount { get; set; }
  }
}