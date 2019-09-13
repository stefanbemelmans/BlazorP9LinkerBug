namespace P9Control.Client.Features.EventStream.Components
{
  using System.Collections.Generic;
  using P9Control.Client.Features.Base.Components;

  public class EventStreamBase : BaseComponent
  {
    public IReadOnlyList<string> Events => EventStreamState.Events;
  }
}
