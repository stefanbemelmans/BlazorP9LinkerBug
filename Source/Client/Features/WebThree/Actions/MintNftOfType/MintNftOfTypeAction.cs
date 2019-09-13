
namespace P9Control.Client.Features.WebThree.Actions.MintNft
{
  using MediatR;
  using P9Control.Client.Features.WebThree;
  public class MintNftOfTypeClientAction : IRequest<WebThreeState>
  {
    public uint MintNftId { get; set; }
    public string ImmutableDataString { get; set; }
    public string MutableDataString { get; set; }
    //MintNftOfTypeFunctionInput MintNftInput = new MintNftOfTypeFunctionInput();
  }
}
