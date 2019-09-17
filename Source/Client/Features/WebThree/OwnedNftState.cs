namespace P9Control.Client.Features.WebThree
{ 
  using BlazorState;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Collections.Generic;

  internal partial class OwnedNftState : State<OwnedNftState>
  {
    public TokenBase CurrentTokenData { get; set; }
    public uint CurrentTokenNftType { get; set; }
    public ImmutableObjectBase ImmutableObject { get; set; }
    public string MutableDataString { get; set; }
    public List<uint> OwnedTokenIdList { get; set; }
    public List<TokenBase> TokenDataList { get; set; }
    public int TotalTokenTypes { get; set; }
    public OwnedNftState() { }
    protected override void Initialize() { }
  }
}