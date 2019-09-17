namespace P9Control.Client.Features.WebThree
{
  using MediatR;

  public class FetchTokenNftTypeAction : IRequest<OwnedNftState>
  {
   public int TokenId { get; set; }
  }
}
