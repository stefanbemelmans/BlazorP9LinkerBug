namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftTypes
{
  using System;
  using P9Control.Api.Features.Base;

  public class GetNftTypesSharedResponse : BaseResponse
  {
    public GetNftTypesSharedResponse() { }

    public GetNftTypesSharedResponse(Guid aRequestId)
    {
      
      RequestId = aRequestId;
    }

    public uint TotalNftTypes { get; set; }
  }
}