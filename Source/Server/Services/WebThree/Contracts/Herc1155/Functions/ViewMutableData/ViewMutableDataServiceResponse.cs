namespace P9Control.Server.Services.WebThree.Contracts.Herc1155
{
  using Nethereum.ABI.FunctionEncoding.Attributes;
    public class ViewMutableDataServiceResponse : IFunctionOutputDTO
  {
    [Parameter(type: "string", 1)]
    public string MutableDataString { get; set; }
    }
}
