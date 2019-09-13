namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using P9Control.Api.Features.Base;
  using System;
  using System.Collections.Generic;

  public class GetAllOwnedTokensSharedResponse : BaseResponse
  {
    public List<uint> TokenIdList { get; set; }

    public GetAllOwnedTokensSharedResponse() { }

    public GetAllOwnedTokensSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
  }
}