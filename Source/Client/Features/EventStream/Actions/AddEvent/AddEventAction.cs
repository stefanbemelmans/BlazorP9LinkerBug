namespace P9Control.Client.Features.EventStream
{
  using MediatR;

  public class AddEventAction : IRequest<EventStreamState>
  {
    public string Message { get; set; }
  }
}
