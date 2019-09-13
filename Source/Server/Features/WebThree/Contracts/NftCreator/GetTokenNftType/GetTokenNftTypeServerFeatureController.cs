namespace P9Control.Server.Features.WebThree.Contracts.NftCreator.GetTokenNftType
{
  using System.Threading.Tasks;
  using P9Control.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType;

  [Route(GetTokenNftTypeSharedRequest.Route)]
  public class GetTokenNftTypeServerFeaturesController : BaseController<GetTokenNftTypeSharedRequest, GetTokenNftTypeSharedResponse> 
  {
    public async Task<IActionResult> Get(GetTokenNftTypeSharedRequest aRequest) => await Send(aRequest);
  }
}
