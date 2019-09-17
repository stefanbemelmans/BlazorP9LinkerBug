namespace P9Control.Client.Features.Base
{
  using BlazorState;
  using MediatR;
  using P9Control.Client.Features.Application;
  using P9Control.Client.Features.Counter;
  using P9Control.Client.Features.EventStream;
  using P9Control.Client.Features.WeatherForecast;
  using P9Control.Client.Features.WebThree;

  /// <summary>
  /// Base Handler that makes it easy to access state
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  /// <typeparam name="TState"></typeparam>
  internal abstract class BaseHandler<TRequest, TState> : BlazorState.RequestHandler<TRequest, TState>
    where TRequest : IRequest<TState>
    where TState : IState
  {
    protected ApplicationState ApplicationState => Store.GetState<ApplicationState>();

    protected CounterState CounterState => Store.GetState<CounterState>();

    protected EventStreamState EventStreamState => Store.GetState<EventStreamState>();

    protected MintNftState MintNftState => Store.GetState<MintNftState>();

    protected OwnedNftState OwnedNftState => Store.GetState<OwnedNftState>();

    protected WeatherForecastsState WeatherForecastsState => Store.GetState<WeatherForecastsState>();

    public BaseHandler(IStore aStore) : base(aStore) { }
  }
}