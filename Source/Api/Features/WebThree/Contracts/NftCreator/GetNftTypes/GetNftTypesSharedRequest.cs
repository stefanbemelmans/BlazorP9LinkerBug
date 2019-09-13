namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftTypes

{
  using P9Control.Api.Features.Base;
  using MediatR;

public class GetNftTypesSharedRequest : BaseRequest, IRequest<GetNftTypesSharedResponse>
  {
    public const string Route = "api/getNftTypes";
  }

}