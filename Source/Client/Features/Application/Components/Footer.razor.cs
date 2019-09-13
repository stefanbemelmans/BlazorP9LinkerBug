namespace P9Control.Client.Features.Application.Components
{
  using P9Control.Client.Features.Base.Components;

  public class FooterBase: BaseComponent
  {
    protected string Version => ApplicationState.Version;
  }
}
