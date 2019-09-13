namespace P9Control.Server.Services.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{ 
  using P9Control.Api.Features.Base;
  using P9Control.Api.Features.WebThree;
  using System.Collections.Generic;

  public class GetAllOwnedTokensServiceResponse : BaseResponse
    {
    public List<uint> TokenIdList { get; set; }
    }
}
