namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.MintNftOfType
{
  using Nethereum.Hex.HexTypes;
  using Nethereum.RPC.Eth.DTOs;
  using P9Control.Api.Features.Base;
  using System.Numerics;

  public class MintNftOfTypeSharedResponse : BaseResponse
  {
    public TransactionReceipt MintingTransactionReceipt { get; set; }

    public int TokenId { get; set; }
    public string TransactionHash { get; set; }

    public HexBigInteger GasUsed { get; set; }
  }
}