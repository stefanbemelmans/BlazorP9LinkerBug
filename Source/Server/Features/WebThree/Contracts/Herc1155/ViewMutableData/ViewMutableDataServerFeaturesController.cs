namespace P9Control.Server.Features.WebThree.Contracts.Herc1155.ViewMutableData
{
  using System.Threading.Tasks;
  using P9Control.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155;

[Route(ViewMutableDataSharedRequest.Route)]
public class ViewMutableDataServerFeaturesController : BaseController<ViewMutableDataSharedRequest, ViewMutableDataSharedResponse>
  {
    public async Task<IActionResult> Get(ViewMutableDataSharedRequest aRequest) => await Send(aRequest);
  }
}
