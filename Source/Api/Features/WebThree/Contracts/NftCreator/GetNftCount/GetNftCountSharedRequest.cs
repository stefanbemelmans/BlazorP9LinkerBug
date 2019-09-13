namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftCount

{
  using P9Control.Api.Features.Base;
  using MediatR;

public class GetNftCountSharedRequest : BaseRequest, IRequest<GetNftCountSharedResponse>
  {
    public const string Route = "api/getNftCount";
  }

}