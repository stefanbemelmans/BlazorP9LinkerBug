namespace P9Control.Client.Pages
{
  //using AnySerializer;
  using P9Control.Api.Features.WebThree;
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree;
  using P9Control.Client.Features.WebThree.Actions.MintNft;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System;

  public class MintNftPageBase : BaseComponent
  {
    public NftTemplate CurrentNftTemplate
    {
      get => WebThreeState.CurrentNftTemplate;
      set { }
    }

    public ImmutableObjectBase FormData
    {
      get => WebThreeState.ImmutableObject;
      set { }
    }

    public bool HasMinted { get; set; } = false;
    public bool IsMinting { get; set; } = false;

    public string MutableDataString
    {
      get => WebThreeState.MutableDataString;
      set { }
    }

    public bool ShowMintingButton { get; set; } = true;

    // These values are gotten in the AssetNftPageModel Init
    public uint TotalNfts
    {
      get => WebThreeState.TotalNftTypes;
      set { }
    }

    //public async void MintNft()
    //{
    //  ShowMintingButton = false;
    //  IsMinting = true;

    //  byte[] serializedImmutableObject = Serializer.Serialize(FormData);

    //  string serializedObjectAsBase64String = Convert.ToBase64String(serializedImmutableObject);

    //  WebThreeState mintingResponse = await Mediator.Send(new MintNftOfTypeClientAction()
    //  {
    //    ImmutableDataString = serializedObjectAsBase64String,
    //    MutableDataString = MutableDataString,
    //    MintNftId = CurrentNftTemplate.NftId
    //  });

    //  IsMinting = false;
    //  HasMinted = true;
    //}

    public void ToggleHasMinted()
    {
      HasMinted = !HasMinted;
      ToggleIsMinting();
    }

    public void ToggleIsMinting() => IsMinting = !IsMinting;

    public void ToggleMintingButton() => ShowMintingButton = !ShowMintingButton;
  }
}