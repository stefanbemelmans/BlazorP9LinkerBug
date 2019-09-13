namespace P9Control.Api.Constants.ContractConstants.NftCreator
{
    public class NftCreatorAbi
    {

        public static string Abi =
        @"[
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
            ""type"": ""function"",
            ""signature"": ""0x006e75ec""
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
            ""type"": ""function"",
            ""signature"": ""0x0d0e96da""
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
            ""type"": ""function"",
            ""signature"": ""0x1dbb9381""
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
            ""type"": ""function"",
            ""signature"": ""0x399c796f""
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
            ""type"": ""function"",
            ""signature"": ""0x43183834""
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
            ""type"": ""function"",
            ""signature"": ""0x6eb3cd49""
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
            ""type"": ""function"",
            ""signature"": ""0x76127291""
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
            ""type"": ""function"",
            ""signature"": ""0x80443378""
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
            ""type"": ""function"",
            ""signature"": ""0x9568e136""
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
            ""type"": ""function"",
            ""signature"": ""0xbc197c81""
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
            ""type"": ""function"",
            ""signature"": ""0xc1292cc3""
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
            ""name"": ""tokenType"",
            ""outputs"": [
              {
                ""name"": """",
                ""type"": ""uint256""
              }
            ],
            ""payable"": false,
            ""stateMutability"": ""view"",
            ""type"": ""function"",
            ""signature"": ""0xe6c3b1f6""
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
            ""type"": ""function"",
            ""signature"": ""0xf23a6e61""
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
            ""inputs"": [
              {
                ""name"": ""_token"",
                ""type"": ""address""
              },
              {
                ""name"": ""_primaryToken"",
                ""type"": ""uint256""
              }
            ],
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
            ""name"": ""AddNFTTemplate"",
            ""outputs"": [],
            ""payable"": false,
            ""stateMutability"": ""nonpayable"",
            ""type"": ""function"",
            ""signature"": ""0xa2607e19""
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
            ""type"": ""function"",
            ""signature"": ""0x9a24c79a""
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
            ""type"": ""function"",
            ""signature"": ""0xba2d56a8""
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
            ""type"": ""function"",
            ""signature"": ""0xa175b638""
          },
          {
            ""constant"": true,
            ""inputs"": [
              {
                ""name"": ""id"",
                ""type"": ""uint256""
              }
            ],
            ""name"": ""getNFTData"",
            ""outputs"": [
              {
                ""name"": """",
                ""type"": ""string""
              },
              {
                ""name"": """",
                ""type"": ""string""
              },
              {
                ""name"": """",
                ""type"": ""uint256""
              },
              {
                ""name"": """",
                ""type"": ""uint256""
              }
            ],
            ""payable"": false,
            ""stateMutability"": ""view"",
            ""type"": ""function"",
            ""signature"": ""0x0ad4c4f4""
          },
          {
            ""constant"": true,
            ""inputs"": [
              {
                ""name"": ""_type"",
                ""type"": ""uint256""
              }
            ],
            ""name"": ""getAllTokensofType"",
            ""outputs"": [
              {
                ""name"": ""List"",
                ""type"": ""uint256[100]""
              }
            ],
            ""payable"": false,
            ""stateMutability"": ""view"",
            ""type"": ""function"",
            ""signature"": ""0x9380289f""
          }
        ]";
    }
}