namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.GetTokenNftType
{
  using Nethereum.ABI.FunctionEncoding.Attributes;

  [FunctionOutput]
  public class GetTokenNftTypeServiceResponse : IFunctionOutputDTO
  {
    [Parameter(type: "uint", 1)]
    public uint NftId { get; set; }

  }
}