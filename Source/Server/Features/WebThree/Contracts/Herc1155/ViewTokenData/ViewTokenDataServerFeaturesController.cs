namespace P9Control.Server.Features.WebThree.Contracts.Herc1155.ViewTokenData
{
  using System.Threading.Tasks;
  using P9Control.Server.Features.Base;
  using Microsoft.AspNetCore.Mvc;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155;
    using P9Control.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData;

    [Route(ViewTokenDataSharedRequest.Route)]
public class ViewTokenDataServerFeaturesController : BaseController<ViewTokenDataSharedRequest, ViewTokenDataSharedResponse>
  {
    public async Task<IActionResult> Get(ViewTokenDataSharedRequest aRequest) => await Send(aRequest);
  }
}
