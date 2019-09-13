
namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.AddNewTemplate
{
  using P9Control.Api.Features.Base;
  public class AddNewTemplateSharedResponse : BaseResponse
  {
    public Nethereum.RPC.Eth.DTOs.TransactionReceipt NewTemplateTransactionReceipt { get; set; }

  }
}
