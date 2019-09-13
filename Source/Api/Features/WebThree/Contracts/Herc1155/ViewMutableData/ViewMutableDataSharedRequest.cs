namespace P9Control.Api.Features.WebThree.Contracts.Herc1155
{
  using MediatR;
  using P9Control.Api.Features.Base;

  public class ViewMutableDataSharedRequest : BaseRequest, IRequest<ViewMutableDataSharedResponse>
  {
    public const string Route = "api/viewMutableData";

    public uint ViewTokenId { get; set; }

    public static string RouteFactory(uint aId) => $"api/viewMutableData?ViewTokenId={aId}";
  }
}