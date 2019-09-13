namespace P9Control.Client.Features.Base.Components
{
  using P9Control.Client.Features.Application;

  public class ResetButtonBase : BaseComponent
  {
    protected void ButtonClick() => Mediator.Send(new ResetStoreAction());
  }
}