namespace P9Control.Client.Features.WebThree.Actions
{
  using BlazorState;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.ChangeCurrentToken;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class OwnedNftState : State<OwnedNftState>
  {
    public class ChangeCurrentTokenHandler : BaseHandler<ChangeCurrentTokenAction, OwnedNftState>
    {
      public ChangeCurrentTokenHandler
         (
           IStore aStore
         ) : base(aStore)
      {
      }

      public override Task<OwnedNftState> Handle
        (
          ChangeCurrentTokenAction aChangeCurrentTokenRequest,
          CancellationToken aCancellationToken
        )
      {
        int TokenId = aChangeCurrentTokenRequest.TokenId;
        OwnedNftState WebThreeState = Store.GetState<OwnedNftState>();
        //string requestUri = QueryHelpers.AddQueryString(GetNftByTypeSharedRequest.Route, "GetNftType", getNftId.ToString());

        TokenBase newSelectedToken = WebThreeState.TokenDataList.Find(token => token.TokenId == TokenId);

        WebThreeState.CurrentTokenData = newSelectedToken;

        return Task.FromResult(WebThreeState);
      }
    }
  }
}