namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType
{
  using System;
  using P9Control.Api.Features.Base;

  public class GetTokenNftTypeSharedResponse : BaseResponse
  {
    public GetTokenNftTypeSharedResponse() { }
    public GetTokenNftTypeSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
    public uint NftId { get; set; }
  }
}