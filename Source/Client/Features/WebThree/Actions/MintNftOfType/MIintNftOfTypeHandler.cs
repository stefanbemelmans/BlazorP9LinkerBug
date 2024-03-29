﻿namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.MintNft;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class WebThreeState : State<WebThreeState>
  {
    public class MintNftOfTypeHandler : BaseHandler<MintNftOfTypeClientAction, WebThreeState>
    {
      private HttpClient HttpClient { get; }

      public MintNftOfTypeHandler
                      (
            IStore aStore,
            HttpClient aHttpClient
          ) : base(aStore)
      {
        HttpClient = aHttpClient;
      }

      public override async Task<WebThreeState> Handle
           (
             MintNftOfTypeClientAction aMintNftClientRequest,
             CancellationToken aCancellationToken
           )
      {
        var mintingRequest = new MintNftOfTypeSharedRequest()
        {
          MintNftId = (int)aMintNftClientRequest.MintNftId,
          ImmutableDataString = aMintNftClientRequest.ImmutableDataString,
          MutableDataString = aMintNftClientRequest.MutableDataString
        };
        WebThreeState WebThreeState = Store.GetState<WebThreeState>();
        //string uri = MintNftOfTypeSharedRequest.RouteFactory((int)aMintNftClientRequest.MintNftId, aMintNftClientRequest.MutableDataString, aMintNftClientRequest.ImmutableDataString);
        MintNftOfTypeSharedResponse mintingResponse = await HttpClient.SendJsonAsync<MintNftOfTypeSharedResponse>(HttpMethod.Post, MintNftOfTypeSharedRequest.Route, mintingRequest);

        WebThreeState.MintingResponse.TransactionHash = mintingResponse.TransactionHash;
        WebThreeState.MintingResponse.NewTokenId = mintingResponse.TokenId;
        WebThreeState.MintingResponse.GasUsed = mintingResponse.GasUsed;

        return WebThreeState;
      }
    }
  }
}