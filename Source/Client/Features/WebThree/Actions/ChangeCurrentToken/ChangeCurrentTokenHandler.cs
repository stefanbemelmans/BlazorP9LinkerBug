namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using P9Control.Client.Features.Base;
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
        OwnedNftState OwnedNftState = Store.GetState<OwnedNftState>();
        //string requestUri = QueryHelpers.AddQueryString(GetNftByTypeSharedRequest.Route, "GetNftType", getNftId.ToString());

        TokenBase newSelectedToken = OwnedNftState. TokenDataList.Find(token => token.TokenId == TokenId);

        OwnedNftState.CurrentTokenData = newSelectedToken;

        return Task.FromResult(OwnedNftState);
      }
    }
  }
}