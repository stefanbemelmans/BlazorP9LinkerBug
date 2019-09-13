namespace P9Control.Client.Pages
{
  using System.Threading.Tasks;
  using P9Control.Client.Features.Base.Components;

  public class WeatherForecastsPageBase : BaseComponent
  {
    public const string Route = "/weatherforecasts";

    protected override async Task OnInitializedAsync() =>
      await Mediator.Send(new Features.WeatherForecast.FetchWeatherForecastsAction());
  }
}