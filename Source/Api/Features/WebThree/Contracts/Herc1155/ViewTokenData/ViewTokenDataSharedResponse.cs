namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData
{
  using P9Control.Api.Features.Base;
  using System;

  public class ViewTokenDataSharedResponse : BaseResponse
  {
    public string TokenDataString { get; set; }

    public ViewTokenDataSharedResponse() { }

    public ViewTokenDataSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }

    // Token Type will determine what object to use to deserialize the data
    //public uint TokenNftType { get; set; }
  }
}