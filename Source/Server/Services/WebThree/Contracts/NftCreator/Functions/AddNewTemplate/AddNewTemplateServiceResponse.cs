namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.AddNewTemplate
{
  using P9Control.Api.Features.Base;

  public class AddNewTemplateServiceResponse : BaseResponse
  {

   public Nethereum.RPC.Eth.DTOs.TransactionReceipt NewTemplateTransactionReceipt { get; set; }
    
    
    // No response for this function 
    // emits  event URI(string _value, uint256 indexed _id);

    /**
        @notice Transfers value amount of an _id from the _from address to the _to address specified.
        @dev MUST emit TransferSingle event on success.
        Caller must be approved to manage the _from account's tokens (see isApprovedForAll).
        MUST throw if `_to` is the zero address.
        MUST throw if balance of sender for token `_id` is lower than the `_value` sent.
        MUST throw on any other error.
        When transfer is complete, this function MUST check if `_to` is a smart contract (code size > 0). If so, it MUST call `onERC1155Received` on `_to` and revert if the return value is not `bytes4(keccak256("onERC1155Received(address,address,uint256,uint256,bytes)"))`.
        @param _from    Source address
        @param _to      Target address
        @param _id      ID of the token type
        @param _value   Transfer amount
        @param _data    Additional data with no specified format, sent in call to `_to`
}
      **/
  }
}
    