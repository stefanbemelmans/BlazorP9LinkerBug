namespace P9Control.Client.Features.Application.Components
{
  using P9Control.Client.Features.Base.Components;

  public class NavBarBase : BaseComponent
  {
    protected string NavMenuCssClass => ApplicationState.IsMenuExpanded ? null : "collapse";
    protected async void ToggleNavMenu() => await Mediator.Send(new ToggleMenuAction());
  }
}
