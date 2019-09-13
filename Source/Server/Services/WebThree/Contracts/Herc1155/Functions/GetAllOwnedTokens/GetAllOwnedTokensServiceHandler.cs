namespace P9Control.Server.Services.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using System.Threading.Tasks;
  using System.Threading;
  using Nethereum.Contracts;
  using P9Control.Server.Services.WebThree.Contracts.Herc1155.ContractInstance;
  using MediatR;
  using P9Control.Api.Constants.AccountAddresses;
  using System.Collections.Generic;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155.GetAllOwnedTokens;

  public class GetAllOwnedTokensServerServiceHandler : IRequestHandler<GetAllOwnedTokensServiceRequest, GetAllOwnedTokensServiceResponse>
  {
    Herc1155Instance Herc1155Instance { get; set; }

    public GetAllOwnedTokensServerServiceHandler(Herc1155Instance aHerc1155Instance)
    {
      Herc1155Instance = aHerc1155Instance;
    }
    public async Task<GetAllOwnedTokensServiceResponse> Handle(GetAllOwnedTokensServiceRequest aGetAllOwnedTokensServiceRequest, CancellationToken aCancellationToken)
    {
      Function<GetAllOwnedTokensFunctionInput> aGetAllOwnedTokensFunction = Herc1155Instance.Instance.GetFunction<GetAllOwnedTokensFunctionInput>();

      List<uint> response = await aGetAllOwnedTokensFunction.CallAsync<List<uint>>(
        new GetAllOwnedTokensFunctionInput
        {
          TokenOwner = TestEthAccounts.TestEthAccountAddress,
        }
        );

      return new GetAllOwnedTokensServiceResponse
      {
        TokenIdList = response
      };

    }
  }
}


