namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType
{
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using Nethereum.Contracts;

  // Mints the selected NFT template
  // Triggers Herc1155 Transfer Single Event
  [Function("mintNFT")]
  public class MintNftOfTypeFunctionInput : FunctionMessage
  {
    [Parameter(type: "uint", name: "type", 1)]
    public int NftId { get; set; }

    [Parameter("string", "data", 2)]
    public string ImmutableDataString { get; set; }

    [Parameter("string", "mutabledata", 3)]
    public string MutableDataString { get; set; }

  }
}
