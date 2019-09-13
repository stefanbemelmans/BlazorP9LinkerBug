namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData
{
  using MediatR;
  using P9Control.Api.Features.Base;

  public class ViewTokenDataSharedRequest : BaseRequest, IRequest<ViewTokenDataSharedResponse>
  {
    public const string Route = "api/viewTokenData";

    public uint TokenIdToGet { get; set; }

    public static string RouteFactory(int aId) => $"api/viewTokenData?TokenIdToGet={aId}";
  }
}