namespace P9Control.Api.Features.WebThree.Contracts.Herc1155
{
  using P9Control.Api.Features.Base;
  using System;

  public class ViewMutableDataSharedResponse : BaseResponse
  {
    public string MutableDataString { get; set; }

    public ViewMutableDataSharedResponse() { }

    public ViewMutableDataSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
  }
}