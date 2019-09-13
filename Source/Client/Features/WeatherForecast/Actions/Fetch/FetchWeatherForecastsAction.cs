namespace P9Control.Client.Features.WeatherForecast
{
  using MediatR;

  public class FetchWeatherForecastsAction : IRequest<WeatherForecastsState> { }
}