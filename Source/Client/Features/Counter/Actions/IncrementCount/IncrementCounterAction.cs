namespace P9Control.Client.Features.Counter
{
  using MediatR;
  using P9Control.Api.Features.Base;

  public class IncrementCounterAction : BaseRequest, IRequest<CounterState>
  {
    public int Amount { get; set; }
  }
}