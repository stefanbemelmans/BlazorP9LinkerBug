namespace P9Control.Client.Pages
{
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree;
  using P9Control.Client.Features.WebThree.Actions;
  using P9Control.Client.Features.WebThree.Actions.ChangeCurrentToken;
  using P9Control.Client.Features.WebThree.Actions.GetAllOwnedTokens;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using P9Control.Api.Features.WebThree;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  public class AssetNftPageBase : BaseComponent
  {

    //public TokenBase CurrentTokenData => WebThreeState.CurrentTokenData;

    public static string Route = "/assetNft";
    public List<uint> OwnedTokenIdList
    {
      get => OwnedNftState.OwnedTokenIdList;
      set { }
    }

    public TokenBase CurrentTokenData
    {
      get => OwnedNftState.CurrentTokenData;
      set { }
    }

    protected async Task OnInitAsync()
    {
      // Getting All Nft Types
      await Mediator.Send(new GetNftTypesClientFeaturesAction());

      //TotalNfts = w3s.TotalNftTypes;

      await Mediator.Send(new GetAllOwnedTokensAction());
    }
  }
}