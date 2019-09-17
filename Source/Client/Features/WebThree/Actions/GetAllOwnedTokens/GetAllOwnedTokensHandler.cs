namespace P9Control.Client.Features.WebThree
{ 
  using BlazorState;
  using Microsoft.AspNetCore.Components;
  using P9Control.Api.Features.WebThree;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155.BalanceOf;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155.ViewTokenData;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.GetTokenNftType;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Collections.Generic;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class OwnedNftState
  {
    public class GetAllOwnedTokensHandler : BaseHandler<GetAllOwnedTokensAction, OwnedNftState>
    {
      private HttpClient HttpClient { get; }

      private List<TokenBase> TokenDataList { get; set; }

      public GetAllOwnedTokensHandler
        (
          IStore aStore,
          HttpClient aHttpClient

        ) : base(aStore)
      {
        HttpClient = aHttpClient;
      }

      public override async Task<OwnedNftState> Handle
        (
          GetAllOwnedTokensAction aGetAllOwnedTokensClientRequest,
          CancellationToken aCancellationToken
        )
      {
        TokenDataList = new List<TokenBase>();
        OwnedNftState OwnedNftState = Store.GetState<OwnedNftState>();
        GetAllOwnedTokensSharedResponse aTokenList = await HttpClient.GetJsonAsync<GetAllOwnedTokensSharedResponse>(GetAllOwnedTokensSharedRequest.Route);

        OwnedNftState.OwnedTokenIdList = aTokenList.TokenIdList;

        if (aTokenList.TokenIdList.Count > 0)
        {
          foreach (uint token in aTokenList.TokenIdList)
          {
            // TokenId

            var ownedToken = new TokenBase() { TokenId = token };

            // TokenNFtTypeId

            ownedToken.TemplateData = await GetNft(ownedToken.TokenId);

            // Get Token Nft Type Data

            // Token Balance

            ownedToken.Balance = await GetBalance(token);

            // Token ImmutableData (Data)

            string aDataString = await GetDataString(token);

            //DeserializeAndAddData(ownedToken, aDataString);
          }
          OwnedNftState.TokenDataList = TokenDataList;
          OwnedNftState.CurrentTokenData = TokenDataList[0];
          OwnedNftState.CurrentTokenNftType = OwnedNftState.CurrentTokenData.TemplateData.NftId;
        }
        return WebThreeState;
      }

      //  Moving this function to Api to work around the cursed Mono.Cecil Linker bug

      //private void DeserializeAndAddData(TokenBase aOwnedToken, string aDataString)
      //{
      //  if (aOwnedToken.TemplateData.NftId == 1)
      //  {
      //    byte[] serializedImmutableData = Convert.FromBase64String(aDataString);

      //    PurchaseOrderData aDeserializedObject = Serializer.Deserialize<PurchaseOrderData>(serializedImmutableData, options); // options == 0

      //    aOwnedToken.PurchaseOrderData = aDeserializedObject;

      //    // Add to StateList
      //    TokenDataList.Add(aOwnedToken);
      //  }
      //  else
      //  {
      //    aOwnedToken.Data = aDataString;

      //    TokenDataList.Add(aOwnedToken);
      //  }
      //}

      private async Task<int> GetBalance(uint aToken)
      {
        BalanceOfSharedResponse aBalanceContainer = await HttpClient.GetJsonAsync<BalanceOfSharedResponse>(BalanceOfSharedRequest.RouteFactory((int)aToken));
        return aBalanceContainer.Balance;
      }

      private async Task<string> GetDataString(uint aToken)
      {
        ViewTokenDataSharedResponse dataString = await HttpClient.GetJsonAsync<ViewTokenDataSharedResponse>(ViewTokenDataSharedRequest.RouteFactory((int)aToken));
        string aDataString = dataString.TokenDataString;
        return aDataString;
      }

      private async Task<NftTemplate> GetNft(uint aToken)
      {   // TokenNftTypeData Should already have the data in state so no need to make a service call
        OwnedNftState WebThreeState = Store.GetState<OwnedNftState>();
        GetTokenNftTypeSharedResponse nftContainer = await HttpClient.GetJsonAsync<GetTokenNftTypeSharedResponse>(GetTokenNftTypeSharedRequest.RouteFactory((int)aToken));
        NftTemplate template = WebThreeState.TemplateDataList.Find(aNft => aNft.NftId == nftContainer.NftId);
        return template;
      }
    }
  }
}