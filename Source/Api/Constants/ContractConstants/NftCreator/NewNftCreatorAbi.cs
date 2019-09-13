namespace P9Control.Api.Constants.ContractConstants.NftCreator
{
  public class NewNftCreatorAbi
  {
    public static string Abi = @"
[
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""lastData"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""totalNFTs"",
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
      ""name"": ""shouldReject"",
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
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""attachedTokens"",
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
      ""name"": ""lastValue"",
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
      ""name"": ""lastOperator"",
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
      ""inputs"": [],
      ""name"": ""renounceOwnership"",
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
      ""name"": ""NFTTemplates"",
      ""outputs"": [
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
        },
        {
          ""name"": ""attachedTokens"",
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
      ""name"": ""lastFrom"",
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
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""NOT_ERC1155_RECEIVED"",
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
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_operator"",
          ""type"": ""address""
        },
        {
          ""name"": ""_from"",
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
      ""name"": ""onERC1155BatchReceived"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes4""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": true,
      ""inputs"": [],
      ""name"": ""lastId"",
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
      ""name"": ""tokenType"",
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
          ""name"": ""_operator"",
          ""type"": ""address""
        },
        {
          ""name"": ""_from"",
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
      ""name"": ""onERC1155Received"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bytes4""
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
      ""inputs"": [
        {
          ""name"": ""_token"",
          ""type"": ""address""
        },
        {
          ""name"": ""_primaryTokenId"",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""constructor""
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
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_name"",
          ""type"": ""string""
        },
        {
          ""name"": ""_symbol"",
          ""type"": ""string""
        },
        {
          ""name"": ""_mintlimit"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""_attachedtokens"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""CreateTemplate"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_type"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""data"",
          ""type"": ""string""
        },
        {
          ""name"": ""mutabledata"",
          ""type"": ""string""
        }
      ],
      ""name"": ""mintNFT"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""nft"",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""withdrawAttached"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""_value"",
          ""type"": ""bool""
        }
      ],
      ""name"": ""setShouldReject"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function""
    }
  ]";
  }
}
