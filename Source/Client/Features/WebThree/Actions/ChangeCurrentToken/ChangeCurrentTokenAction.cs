namespace P9Control.Client.Features.WebThree
{
  using MediatR;
  using P9Control.Api.Features.Base;
  public class ChangeCurrentTokenAction : BaseRequest, IRequest<OwnedNftState>
  {
    public int TokenId { get; set; }
  }
}