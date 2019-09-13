namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftByType
{
  using System;
  using P9Control.Api.Features.Base;

  public class GetNftByTypeSharedResponse : BaseResponse
  {
    public GetNftByTypeSharedResponse() { }
    public GetNftByTypeSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
    public NftTemplate NftTypeDto { get; set; }
  }
}