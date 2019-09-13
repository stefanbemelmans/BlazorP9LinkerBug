namespace P9Control.Client.Features.WebThree.Components
{
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.Base.Components;

  public class MintingModalBase : BaseComponent
  {
    [Parameter]
    public bool IsMinting { get; set; } = false;

    public void ChangeModalState() => IsMinting = !IsMinting;

  }
}
