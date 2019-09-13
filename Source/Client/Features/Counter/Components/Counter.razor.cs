namespace P9Control.Client.Features.Counter.Components
{
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.Counter;
  using System.Threading.Tasks;

  public class CounterBase : BaseComponent
  {
    protected async Task ButtonClick() =>
      _ = await Mediator.Send(new IncrementCounterAction { Amount = 5 });
  }
}