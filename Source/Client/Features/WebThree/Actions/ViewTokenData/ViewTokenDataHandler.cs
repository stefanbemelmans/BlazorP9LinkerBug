namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.ViewTokenData;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class WebThreeState
  {
    public class ViewTokenDataHandler : BaseHandler<ViewTokenDataAction, WebThreeState>
    {
      public TokenBase CurrentTokenData { get; set; }

      private HttpClient HttpClient { get; }

      public ViewTokenDataHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }

      public override async Task<WebThreeState> Handle
          (
          ViewTokenDataAction aViewTokenDataRequest,
          CancellationToken aCancellationToken
          )
      {
        uint TokenId = aViewTokenDataRequest.TokenIdToGet;
        CurrentTokenData.TokenId = TokenId;

        ViewTokenDataSharedResponse DataString = await HttpClient.GetJsonAsync<ViewTokenDataSharedResponse>(ViewTokenDataSharedRequest.RouteFactory((int)TokenId));
        CurrentTokenData.Data = DataString.TokenDataString;

        return new WebThreeState { CurrentTokenData = CurrentTokenData };
      }
    }
  }
}