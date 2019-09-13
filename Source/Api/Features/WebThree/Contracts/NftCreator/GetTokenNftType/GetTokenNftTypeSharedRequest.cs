namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType
{
  using P9Control.Api.Features.Base;
  using MediatR;

public class GetTokenNftTypeSharedRequest : BaseRequest, IRequest<GetTokenNftTypeSharedResponse>
  {
    public const string Route = "api/GetTokenNftType";

    public static string RouteFactory(int aId) => $"api/GetTokenNftType?TokenId={aId}";
    public uint TokenId { get; set; }
  }

}