namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using P9Control.Api.Features.WebThree;
  using P9Control.Client.Features.Base;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class OwnedNftState
  {
    public class ChangeCurrentNftHandler : BaseHandler<ChangeCurrentNftAction, OwnedNftState>
    {
      public ChangeCurrentNftHandler
         (
           IStore aStore
         ) : base(aStore)
      {
      }

      public override Task<OwnedNftState> Handle
        (
          ChangeCurrentNftAction aChangeCurrentNftRequest,
          CancellationToken aCancellationToken
        )
      {
        OwnedNftState WebThreeState = Store.GetState<OwnedNftState>();
        string templateName = aChangeCurrentNftRequest.TemplateName;

        //string requestUri = QueryHelpers.AddQueryString(GetNftByTypeSharedRequest.Route, "GetNftType", getNftId.ToString());

        NftTemplate newSelectedTemplate = WebThreeState.TemplateDataList.Find(aNft => aNft.Name == templateName);

        WebThreeState.CurrentNftTemplate = newSelectedTemplate;

        return Task.FromResult(WebThreeState);
      }
    }
  }
}