namespace P9Control.Client.Features.WebThree.Actions.ChangeCurrentToken
{
  using MediatR;
  using P9Control.Api.Features.Base;
  using P9Control.Api.Features.WebThree;
  public class ChangeCurrentTokenAction : BaseRequest, IRequest<WebThreeState>
  {
    public int TokenId { get; set; }
  }
}