namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.BalanceOf
{
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using Nethereum.Contracts;

  [Function(name: "balanceOf")] // This works
  public class BalanceOfFunctionInput : FunctionMessage
  {
    [Parameter(type: "uint", name: "id")]
    public uint TokenId { get; set; }

    [Parameter(type: "address", name: "owner", order: 1)]
    public string TokenOwner { get; set; }
  }
}