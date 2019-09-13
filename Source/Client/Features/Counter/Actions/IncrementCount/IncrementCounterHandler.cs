namespace P9Control.Client.Features.Counter
{
  using System.Threading;
  using System.Threading.Tasks;
  using BlazorState;
  using P9Control.Client.Features.Base;

  internal partial class CounterState
  {
    internal class IncrementCounterHandler : BaseHandler<IncrementCounterAction, CounterState>
    {
      public IncrementCounterHandler(IStore aStore) : base(aStore) { }

      public override Task<CounterState> Handle
      (
        IncrementCounterAction aIncrementCounterAction,
        CancellationToken aCancellationToken
      )
      {
        CounterState.Count += aIncrementCounterAction.Amount;
        return Task.FromResult(CounterState);
      }
    }
  }
}