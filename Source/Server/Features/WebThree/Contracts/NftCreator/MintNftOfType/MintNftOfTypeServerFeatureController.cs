namespace P9Control.Server.Features.WebThree.Contracts.NftCreator.MintNftOfType
{
  using System.Threading.Tasks;
  using P9Control.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType;
  
  [Route(MintNftOfTypeSharedRequest.Route)]
  public class MintNftOfTypeServerFeaturesController : BaseController<MintNftOfTypeSharedRequest, MintNftOfTypeSharedResponse> 
  {
    [HttpPost]
    public async Task<IActionResult> Post(MintNftOfTypeSharedRequest aRequest) => await Send(aRequest);
  }
}
