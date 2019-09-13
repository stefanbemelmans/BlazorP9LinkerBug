namespace P9Control.Client.Features.WebThree
{
  using MediatR;

  public class FetchTokenNftTypeAction : IRequest<WebThreeState>
  {
   public int TokenId { get; set; }
  }
}
