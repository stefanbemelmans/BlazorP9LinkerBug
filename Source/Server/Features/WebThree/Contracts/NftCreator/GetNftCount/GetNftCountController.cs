namespace P9Control.Server.Features.WebThree.Contracts.NftCreator.GetNftCount
{
  using System.Threading.Tasks;
  using P9Control.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftTypes;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftCount;

  [Route(GetNftCountSharedRequest.Route)]
  public class GetNftCountServerFeaturesController : BaseController<GetNftCountSharedRequest, GetNftCountSharedResponse> 
  {
    public async Task<IActionResult> Get(GetNftCountSharedRequest aRequest) => await Send(aRequest);
  }
}
