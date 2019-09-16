using BlazorState;
using P9Control.Client.Features.WebThree.Components.NftTemplates;
using System.Collections.Generic;

namespace P9Control.Client.Features.WebThree.OwnedNftState
{
  public partial class OwnedNftState : State<OwnedNftState>
  {
    public TokenBase CurrentTokenData { get; set; }
    public uint CurrentTokenNftType { get; set; }
    public ImmutableObjectBase ImmutableObject { get; set; }
    public string MutableDataString { get; set; }
    public List<uint> OwnedTokenIdList { get; set; }
    public List<TokenBase> TokenDataList { get; set; }
    public uint TotalTokenTypes { get; set; }
    protected override void Initialize() { }
  }
}