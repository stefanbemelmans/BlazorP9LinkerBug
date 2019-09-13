namespace P9Control.Api.Constants.ContractConstants.Herc1155
{
  public static class Herc115520Abi
  {
    public static string Abi = @"[
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_interfaceId"",
          ""type"": ""bytes4""
        }
      ],
      ""name"": ""supportsInterface"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_spender"",
          ""type"": ""address""
        },
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_currentValue"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""amount"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""decreaseApproval"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""owner"",
          ""type"": ""address""
        }
      ],
      ""name"": ""getAllOwnedTokens"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256[]""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""_Symbol"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""string""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""viewTokenData"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""string""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_from"",
          ""type"": ""address""
        },
        {
          ""name"": ""_to"",
          ""type"": ""address""
        },
        {
          ""name"": ""_ids"",
          ""type"": ""uint256[]""
        },
        {
          ""name"": ""_values"",
          ""type"": ""uint256[]""
        },
        {
          ""name"": ""_data"",
          ""type"": ""bytes""
        }
      ],
      ""name"": ""safeBatchTransferFrom"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""owner"",
          ""type"": ""address""
        },
        {
          ""name"": ""index"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""tokenOfOwnerByIndex"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [],
      ""name"": ""unpause"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_tokenId"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""burn"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_owners"",
          ""type"": ""address[]""
        },
        {
          ""name"": ""_ids"",
          ""type"": ""uint256[]""
        }
      ],
      ""name"": ""balanceOfBatch"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256[]""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""paused"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [],
      ""name"": ""renounceOwnership"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_initialSupply"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_uri"",
          ""type"": ""string""
        },
        {
          ""name"": ""_mutabledata"",
          ""type"": ""string""
        },
        {
          ""name"": ""to"",
          ""type"": ""address""
        },
        {
          ""name"": ""name"",
          ""type"": ""string""
        },
        {
          ""name"": ""symbol"",
          ""type"": ""string""
        },
        {
          ""name"": ""mintlimit"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""createfor"",
      ""outputs"": [
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [],
      ""name"": ""pause"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_spender"",
          ""type"": ""address""
        },
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_currentValue"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""amount"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""increaseApproval"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""owner"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""address""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""isOwner"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_initialSupply"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_uri"",
          ""type"": ""string""
        },
        {
          ""name"": ""name"",
          ""type"": ""string""
        },
        {
          ""name"": ""symbol"",
          ""type"": ""string""
        }
      ],
      ""name"": ""create"",
      ""outputs"": [
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""TotalSupply"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""account"",
          ""type"": ""address""
        }
      ],
      ""name"": ""addMinter"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [],
      ""name"": ""renounceMinter"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_data"",
          ""type"": ""uint256[]""
        }
      ],
      ""name"": ""Sum"",
      ""outputs"": [
        {
          ""name"": ""sum"",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""pure"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_operator"",
          ""type"": ""address""
        },
        {
          ""name"": ""_approved"",
          ""type"": ""bool""
        }
      ],
      ""name"": ""setApprovalForAll"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""account"",
          ""type"": ""address""
        }
      ],
      ""name"": ""isMinter"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""nonce"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""s"",
          ""type"": ""string""
        }
      ],
      ""name"": ""editMutableData"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""MintableTokens"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""creators"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""address""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_to"",
          ""type"": ""address[]""
        },
        {
          ""name"": ""_quantities"",
          ""type"": ""uint256[]""
        }
      ],
      ""name"": ""mint"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""viewMutableData"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""string""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""ERC1155_RECEIVED"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes4""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""_Name"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""string""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_owner"",
          ""type"": ""address""
        },
        {
          ""name"": ""_operator"",
          ""type"": ""address""
        }
      ],
      ""name"": ""isApprovedForAll"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_from"",
          ""type"": ""address""
        },
        {
          ""name"": ""_to"",
          ""type"": ""address""
        },
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_value"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_data"",
          ""type"": ""bytes""
        }
      ],
      ""name"": ""safeTransferFrom"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""newOwner"",
          ""type"": ""address""
        }
      ],
      ""name"": ""transferOwnership"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""ERC1155_BATCH_RECEIVED"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes4""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""inputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""constructor""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""from"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""to"",
          ""type"": ""address""
        },
        {
          ""indexed"": false,
          ""name"": ""value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""Transfer"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""owner"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""spender"",
          ""type"": ""address""
        },
        {
          ""indexed"": false,
          ""name"": ""value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""Approval"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""account"",
          ""type"": ""address""
        }
      ],
      ""name"": ""MinterAdded"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""account"",
          ""type"": ""address""
        }
      ],
      ""name"": ""MinterRemoved"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""_owner"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""_spender"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""indexed"": false,
          ""name"": ""_oldValue"",
          ""type"": ""uint256""
        },
        {
          ""indexed"": false,
          ""name"": ""_value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""Approval"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": false,
          ""name"": ""account"",
          ""type"": ""address""
        }
      ],
      ""name"": ""Paused"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": false,
          ""name"": ""account"",
          ""type"": ""address""
        }
      ],
      ""name"": ""Unpaused"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""previousOwner"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""newOwner"",
          ""type"": ""address""
        }
      ],
      ""name"": ""OwnershipTransferred"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""_operator"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""_from"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""_to"",
          ""type"": ""address""
        },
        {
          ""indexed"": false,
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""indexed"": false,
          ""name"": ""_value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""TransferSingle"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""_operator"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""_from"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""_to"",
          ""type"": ""address""
        },
        {
          ""indexed"": false,
          ""name"": ""_ids"",
          ""type"": ""uint256[]""
        },
        {
          ""indexed"": false,
          ""name"": ""_values"",
          ""type"": ""uint256[]""
        }
      ],
      ""name"": ""TransferBatch"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": true,
          ""name"": ""_owner"",
          ""type"": ""address""
        },
        {
          ""indexed"": true,
          ""name"": ""_operator"",
          ""type"": ""address""
        },
        {
          ""indexed"": false,
          ""name"": ""_approved"",
          ""type"": ""bool""
        }
      ],
      ""name"": ""ApprovalForAll"",
      ""type"": ""event""
    },
    {
      ""anonymous"": false,
      ""inputs"": [
        {
          ""indexed"": false,
          ""name"": ""_value"",
          ""type"": ""string""
        },
        {
          ""indexed"": true,
          ""name"": ""_id"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""URI"",
      ""type"": ""event""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_owner"",
          ""type"": ""address""
        },
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""balanceOf"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""owner"",
          ""type"": ""address""
        }
      ],
      ""name"": ""balanceOf"",
      ""outputs"": [
        {
          ""name"": ""balance"",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""to"",
          ""type"": ""address""
        },
        {
          ""name"": ""value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""transfer"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""totalSupply"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""name"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""string""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""symbol"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""string""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""decimals"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint8""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""from"",
          ""type"": ""address""
        },
        {
          ""name"": ""to"",
          ""type"": ""address""
        },
        {
          ""name"": ""value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""transferFrom"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""to"",
          ""type"": ""address""
        },
        {
          ""name"": ""value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""approve"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_spender"",
          ""type"": ""address""
        },
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_currentValue"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_value"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""approve"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_owner"",
          ""type"": ""address""
        },
        {
          ""name"": ""_spender"",
          ""type"": ""address""
        },
        {
          ""name"": ""_id"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""allowance"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""owner"",
          ""type"": ""address""
        },
        {
          ""name"": ""spender"",
          ""type"": ""address""
        }
      ],
      ""name"": ""allowance"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    }
  ]";
  }
}
