namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using MediatR;
  using P9Control.Api.Features.Base;

  public class GetAllOwnedTokensSharedRequest : BaseRequest, IRequest<GetAllOwnedTokensSharedResponse>
  {
    public const string Route = "api/getAllOwnedTokens";
  }
}