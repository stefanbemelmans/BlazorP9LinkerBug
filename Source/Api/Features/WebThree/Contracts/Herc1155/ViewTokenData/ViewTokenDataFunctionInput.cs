namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData
{
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using Nethereum.Contracts;
  using P9Control.Api.Constants.AccountAddresses;

  [Function(name: "viewTokenData")] // This works
  public class ViewTokenDataFunctionInput : FunctionMessage
  {
    [Parameter(type: "uint", name: "_id", order: 1)]
    public uint ViewTokenId { get; set; }

    public ViewTokenDataFunctionInput()
    {
      FromAddress = TestEthAccounts.TestEthAccountAddress;
      Gas = new Nethereum.Hex.HexTypes.HexBigInteger(900000);
      AmountToSend = new Nethereum.Hex.HexTypes.HexBigInteger(0);
    }
  }
}