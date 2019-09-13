namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.ChangeCurrentToken;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class WebThreeState : State<WebThreeState>
  {
    public class ChangeCurrentTokenHandler : BaseHandler<ChangeCurrentTokenAction, WebThreeState>
    {
      public ChangeCurrentTokenHandler
         (
           IStore aStore
         ) : base(aStore)
      {
      }

      public override Task<WebThreeState> Handle
        (
          ChangeCurrentTokenAction aChangeCurrentTokenRequest,
          CancellationToken aCancellationToken
        )
      {
        int TokenId = aChangeCurrentTokenRequest.TokenId;
        WebThreeState WebThreeState = Store.GetState<WebThreeState>();
        //string requestUri = QueryHelpers.AddQueryString(GetNftByTypeSharedRequest.Route, "GetNftType", getNftId.ToString());

        TokenBase newSelectedToken = WebThreeState.TokenDataList.Find(token => token.TokenId == TokenId);

        WebThreeState.CurrentTokenData = newSelectedToken;

        return Task.FromResult(WebThreeState);
      }
    }
  }
}