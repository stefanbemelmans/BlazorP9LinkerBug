namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftCount
{
  using System;
  using P9Control.Api.Features.Base;

  public class GetNftCountSharedResponse : BaseResponse
  {
    public uint NftCount { get; set; }
  }
}