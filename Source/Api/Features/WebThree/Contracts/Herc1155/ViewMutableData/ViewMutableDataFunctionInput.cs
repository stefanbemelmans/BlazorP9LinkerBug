namespace P9Control.Api.Features.WebThree.Contracts.Herc1155
{
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using Nethereum.Contracts;

  [Function(name: "viewMutableData")] // This works
  public class ViewMutableDataFunctionInput : FunctionMessage
  {
    [Parameter(type: "uint", name: "_id", order: 1)]
    public uint ViewTokenId { get; set; }
  }
}