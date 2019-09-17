namespace P9Control.Client.Features.Base.Components
{
  using BlazorState.Pipeline.ReduxDevTools;
  using P9Control.Client.Features.Application;
  using P9Control.Client.Features.Counter;
  using P9Control.Client.Features.WeatherForecast;
  using P9Control.Client.Features.EventStream;
  using P9Control.Client.Features.Transactions;
  using P9Control.Client.Features.WebThree;

  /// <summary>
  /// Makes access to the State a little easier and by inheriting from
  /// BlazorStateDevToolsComponent it allows for ReduxDevTools operation.
  /// </summary>
  /// <remarks>
  /// In production one would NOT be required to use these base components
  /// But would be required to properly implement the required interfaces.
  /// one could conditionally inherit from BaseComponent for production build.
  /// </remarks>
  public class BaseComponent : BlazorStateDevToolsComponent
  {
    internal ApplicationState ApplicationState => GetState<ApplicationState>();
    internal CounterState CounterState => GetState<CounterState>();
    internal EventStreamState EventStreamState => GetState<EventStreamState>();
    internal WeatherForecastsState WeatherForecastsState => GetState<WeatherForecastsState>();
    internal MintNftState MintNftState => GetState<MintNftState>();
    internal OwnedNftState OwnedNftState => GetState<OwnedNftState>();
    internal TransactionState TransactionState=> GetState<TransactionState>();
  }
}