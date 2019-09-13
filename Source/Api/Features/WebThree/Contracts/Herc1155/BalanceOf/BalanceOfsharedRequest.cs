namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.BalanceOf
{
  using MediatR;
  using P9Control.Api.Features.Base;

  public class BalanceOfSharedRequest : BaseRequest, IRequest<BalanceOfSharedResponse>
  {
    public const string Route = "api/balanceOf";

    public uint ViewTokenId { get; set; }

    public static string RouteFactory(int aId) => $"api/balanceOf?ViewTokenId={aId}";
  }
}