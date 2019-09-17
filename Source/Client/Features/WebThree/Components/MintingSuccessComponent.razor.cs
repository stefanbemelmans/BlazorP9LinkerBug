namespace P9Control.Client.Features.WebThree.Components
{
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType;
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree;

  public class MintingSuccessComponentBase : BaseComponent
  {
    public MintNftOfTypeSharedResponse MintingResponse => MintNftState.MintingResponse;
  }
}