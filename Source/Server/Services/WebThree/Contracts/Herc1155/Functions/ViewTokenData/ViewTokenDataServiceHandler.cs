namespace P9Control.Server.Services.WebThree.Contracts.Herc1155.Functions
{
    using System.Threading.Tasks;
    using System.Threading;
    using Nethereum.Contracts;
    using P9Control.Server.Services.WebThree.Contracts.Herc1155.ContractInstance;
    using P9Control.Api.Features.WebThree.Contracts.Herc1155;
    using AnySerializer;
    using MediatR;
    using P9Control.Api.Constants.AccountAddresses;
    using System;

    public class ViewTokenDataServerServiceHandler : IRequestHandler<ViewTokenDataServiceRequest, ViewTokenDataServiceResponse>
    {
        Herc1155Instance Herc1155 { get; set; }

        public ViewTokenDataServerServiceHandler(Herc1155Instance aHerc1155Instance)
        {
            Herc1155 = aHerc1155Instance;
        }

        public async Task<ViewTokenDataServiceResponse> Handle(ViewTokenDataServiceRequest aViewTokenDataServiceRequest, CancellationToken aCancellationToken)
        {
            // using the functionMessage seems to error when it's a simple call. More research needed.
            Function aViewTokenDataFunction = Herc1155.Instance.GetFunction("viewTokenData");
            // TokenId 5 is just a string
            // TokenId 4 Is a string "The First Minted NFT!"
            // TokenId 3 deserializes from base64 into ImmutableData type
            //
            // The Call signature is unavoidable at this point, I have tried the functionMessage, Strongly typing
            // the Function instantiation, creating CallInput, the only thing that seems to work is the explicit below
            //
            string TokenDataString = await aViewTokenDataFunction.CallAsync<string>(
                from: TestEthAccounts.TestEthAccountAddress, gas: new Nethereum.Hex.HexTypes.HexBigInteger(900000),
                value: new Nethereum.Hex.HexTypes.HexBigInteger(0),
                functionInput: aViewTokenDataServiceRequest.ViewTokenId);

            //byte[] serializedImmutableData = Convert.FromBase64String(serializedBase64String);

            return new ViewTokenDataServiceResponse
            {
                TokenDataString = TokenDataString
            };

        }
    }
}


