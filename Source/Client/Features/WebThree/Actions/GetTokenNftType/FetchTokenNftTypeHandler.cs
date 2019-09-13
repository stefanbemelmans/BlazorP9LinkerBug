namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType;
  using P9Control.Client.Features.Base;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class WebThreeState 
  {
    public class FetchTokenNftTypeClientFeaturesHandler : BaseHandler<FetchTokenNftTypeAction, WebThreeState>
    {
      private HttpClient HttpClient { get; }

      public FetchTokenNftTypeClientFeaturesHandler
              (IStore aStore,
          HttpClient aHttpClient
        ) : base(aStore)
      {
        HttpClient = aHttpClient;
      }

      public override async Task<WebThreeState> Handle
      (
        FetchTokenNftTypeAction aFetchTokenNftTypeClientRequest,
        CancellationToken aCancellationToken
      )
      {
        WebThreeState WebThreeState = Store.GetState<WebThreeState>();
        int TokenId = aFetchTokenNftTypeClientRequest.TokenId;

        string requestUri = GetTokenNftTypeSharedRequest.RouteFactory(TokenId);

        GetTokenNftTypeSharedResponse type = await HttpClient.GetJsonAsync<GetTokenNftTypeSharedResponse>(requestUri);

        WebThreeState.CurrentTokenNftType = type.NftId;

        return WebThreeState;
      }
    }
  }
}