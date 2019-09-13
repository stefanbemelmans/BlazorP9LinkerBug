
namespace P9Control.Api.Constants.ContractConstants.Herc1155
{
  public static class ContractAbi
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
      ""type"": ""function"",
      ""signature"": ""0x01ffc9a7""
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
      ""type"": ""function"",
      ""signature"": ""0x0f915c64""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""order"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""client"",
          ""type"": ""address""
        }
      ],
      ""name"": ""delistClient"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function"",
      ""signature"": ""0x14405397""
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
      ""type"": ""function"",
      ""signature"": ""0x1d0f114b""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""order"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""manager"",
          ""type"": ""address""
        }
      ],
      ""name"": ""delistManager"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function"",
      ""signature"": ""0x24b9c75c""
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
      ""type"": ""function"",
      ""signature"": ""0x254cc981""
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
      ""type"": ""function"",
      ""signature"": ""0x2eb2c2d6""
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
      ""type"": ""function"",
      ""signature"": ""0x2f745c59""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""order"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""client"",
          ""type"": ""address""
        }
      ],
      ""name"": ""AssignAsClient"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function"",
      ""signature"": ""0x4208c609""
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
      ""type"": ""function"",
      ""signature"": ""0x42966c68""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": ""_data"",
          ""type"": ""uint256[]""
        }
      ],
      ""name"": ""sumAsm"",
      ""outputs"": [
        {
          ""name"": ""sum"",
          ""type"": ""uint256""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""pure"",
      ""type"": ""function"",
      ""signature"": ""0x4d36b7a4""
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
      ""type"": ""function"",
      ""signature"": ""0x4e1273f4""
    },
    {
      ""constant"": false,
      ""inputs"": [],
      ""name"": ""renounceOwnership"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function"",
      ""signature"": ""0x715018a6""
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
      ""type"": ""function"",
      ""signature"": ""0x83ee81ec""
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
      ""type"": ""function"",
      ""signature"": ""0x8da5cb5b""
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
      ""type"": ""function"",
      ""signature"": ""0x8f32d59b""
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
      ""type"": ""function"",
      ""signature"": ""0x91cf34a5""
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
      ""type"": ""function"",
      ""signature"": ""0x983b2d56""
    },
    {
      ""constant"": false,
      ""inputs"": [],
      ""name"": ""renounceMinter"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function"",
      ""signature"": ""0x98650275""
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
      ""type"": ""function"",
      ""signature"": ""0xa22cb465""
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
      ""type"": ""function"",
      ""signature"": ""0xaa271e1a""
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
      ""type"": ""function"",
      ""signature"": ""0xaffed0e0""
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
      ""type"": ""function"",
      ""signature"": ""0xb9ff093a""
    },
    {
      ""constant"": false,
      ""inputs"": [
        {
          ""name"": ""order"",
          ""type"": ""uint256""
        },
        {
          ""name"": ""manager"",
          ""type"": ""address""
        }
      ],
      ""name"": ""AssignAsManager"",
      ""outputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""function"",
      ""signature"": ""0xbbe1e54a""
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
      ""type"": ""function"",
      ""signature"": ""0xcd53d08e""
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
      ""type"": ""function"",
      ""signature"": ""0xcfa84fc1""
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
      ""type"": ""function"",
      ""signature"": ""0xd418070c""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""address""
        },
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""Client"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function"",
      ""signature"": ""0xd4c0b399""
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
      ""type"": ""function"",
      ""signature"": ""0xe0a5c949""
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
      ""type"": ""function"",
      ""signature"": ""0xe8d0be6b""
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
      ""type"": ""function"",
      ""signature"": ""0xe985e9c5""
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
      ""type"": ""function"",
      ""signature"": ""0xf242432a""
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
      ""type"": ""function"",
      ""signature"": ""0xf2fde38b""
    },
    {
      ""constant"": true,
      ""inputs"": [
        {
          ""name"": """",
          ""type"": ""address""
        },
        {
          ""name"": """",
          ""type"": ""uint256""
        }
      ],
      ""name"": ""Manager"",
      ""outputs"": [
        {
          ""name"": """",
          ""type"": ""bool""
        }
      ],
      ""payable"": false,
      ""stateMutability"": ""view"",
      ""type"": ""function"",
      ""signature"": ""0xf3abb7fb""
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
      ""type"": ""function"",
      ""signature"": ""0xfc67bf1c""
    },
    {
      ""inputs"": [],
      ""payable"": false,
      ""stateMutability"": ""nonpayable"",
      ""type"": ""constructor"",
      ""signature"": ""constructor""
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
      ""type"": ""event"",
      ""signature"": ""0xddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef""
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
      ""type"": ""event"",
      ""signature"": ""0x8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925""
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
      ""type"": ""event"",
      ""signature"": ""0x3a9c85c6b31f7a9d7fe1478f53e1be42e85db97ca30d1789cfef9196dbc472c9""
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
      ""type"": ""event"",
      ""signature"": ""0xc3d58168c5ae7397731d063d5bbf3d657854427343f4c083240f7aacaa2d0f62""
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
      ""type"": ""event"",
      ""signature"": ""0x4a39dc06d4c0dbc64b70af90fd698a233a518aa5d07e595d983b8c0526c8f7fb""
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
      ""type"": ""event"",
      ""signature"": ""0x17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c31""
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
      ""type"": ""event"",
      ""signature"": ""0x6bb7ff708619ba0610cba295a58592e0451dee2622938c8755667688daf3529b""
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
      ""type"": ""event"",
      ""signature"": ""0x6ae172837ea30b801fbfcdd4108aa1d5bf8ff775444fd70256b44e6bf3dfc3f6""
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
      ""type"": ""event"",
      ""signature"": ""0xe94479a9f7e1952cc78f2d6baab678adc1b772d936c6583def489e524cb66692""
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
      ""type"": ""event"",
      ""signature"": ""0x8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e0""
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
      ""type"": ""function"",
      ""signature"": ""0x00fdd58e""
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
      ""type"": ""function"",
      ""signature"": ""0x70a08231""
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
      ""type"": ""function"",
      ""signature"": ""0xa9059cbb""
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
      ""type"": ""function"",
      ""signature"": ""0x18160ddd""
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
      ""type"": ""function"",
      ""signature"": ""0x06fdde03""
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
      ""type"": ""function"",
      ""signature"": ""0x95d89b41""
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
      ""type"": ""function"",
      ""signature"": ""0x313ce567""
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
      ""type"": ""function"",
      ""signature"": ""0x23b872dd""
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
      ""type"": ""function"",
      ""signature"": ""0x095ea7b3""
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
      ""type"": ""function"",
      ""signature"": ""0x4f4df442""
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
      ""type"": ""function"",
      ""signature"": ""0x598af9e7""
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
      ""type"": ""function"",
      ""signature"": ""0xdd62ed3e""
    }
  ]";
  };
};



