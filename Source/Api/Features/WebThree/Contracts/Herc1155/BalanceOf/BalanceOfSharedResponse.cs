namespace P9Control.Api.Features.WebThree.Contracts.Herc1155.BalanceOf
{
  using P9Control.Api.Features.Base;
  using System;

  public class BalanceOfSharedResponse : BaseResponse
  {
    public int Balance { get; set; }

    public BalanceOfSharedResponse() { }

    public BalanceOfSharedResponse(Guid aRequestId)
    {
      RequestId = aRequestId;
    }
  }
}