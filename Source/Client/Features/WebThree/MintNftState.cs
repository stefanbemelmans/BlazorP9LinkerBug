namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using P9Control.Api.Features.WebThree;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Collections.Generic;

  internal partial class MintNftState : State<MintNftState>
  {
    public NftTemplate CurrentNftTemplate { get; set; }
    public int CurrentNftTypeIndex { get; set; } = 0;
    public ImmutableObjectBase ImmutableObject { get; set; }
    public MintNftOfTypeSharedResponse MintingResponse { get; set; }
    public string MutableDataString { get; set; }
    public uint NftCount { get; set; }
    public List<NftTemplate> TemplateDataList { get; set; }
    public uint TotalNftTypes { get; set; }

    protected override void Initialize() { }
  }
}