using BlazorState;
using Nethereum.Hex.HexTypes;
using P9Control.Api.Features.WebThree;
using System.Collections.Generic;

namespace P9Control.Client.Features.WebThree.MintNftState
{
  public class MintingResponse
  {
    public HexBigInteger GasUsed { get; set; }
    public int NewTokenId { get; set; }
    public string TransactionHash { get; set; }
  }

  public partial class MintNftState : State<MintNftState>
  {
    public NftTemplate CurrentNftTemplate { get; set; }
    public int CurrentNftTypeIndex { get; set; } = 0;
    public MintingResponse MintingResponse { get; set; }
    public uint NftCount { get; set; }
    public List<NftTemplate> TemplateDataList { get; set; }
    public uint TotalNftTypes { get; set; }

    protected override void Initialize() { }
  }
}