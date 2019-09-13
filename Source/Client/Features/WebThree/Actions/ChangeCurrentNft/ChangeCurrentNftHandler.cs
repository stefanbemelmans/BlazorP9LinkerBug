namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using P9Control.Api.Features.WebThree;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.ChangeCurrentNft;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class WebThreeState
  {
    public class ChangeCurrentNftHandler : BaseHandler<ChangeCurrentNftAction, WebThreeState>
    {
      public ChangeCurrentNftHandler
         (
           IStore aStore
         ) : base(aStore)
      {
      }

      public override Task<WebThreeState> Handle
        (
          ChangeCurrentNftAction aChangeCurrentNftRequest,
          CancellationToken aCancellationToken
        )
      {
        WebThreeState WebThreeState = Store.GetState<WebThreeState>();
        string templateName = aChangeCurrentNftRequest.TemplateName;

        //string requestUri = QueryHelpers.AddQueryString(GetNftByTypeSharedRequest.Route, "GetNftType", getNftId.ToString());

        NftTemplate newSelectedTemplate = WebThreeState.TemplateDataList.Find(aNft => aNft.Name == templateName);

        WebThreeState.CurrentNftTemplate = newSelectedTemplate;

        return Task.FromResult(WebThreeState);
      }
    }
  }
}