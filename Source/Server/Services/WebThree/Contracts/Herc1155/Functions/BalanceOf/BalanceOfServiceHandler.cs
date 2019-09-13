namespace P9Control.Server.Services.WebThree.Contracts.Herc1155.BalanceOf
{
  using System.Threading.Tasks;
  using System.Threading;
  using Nethereum.Contracts;
  using P9Control.Server.Services.WebThree.Contracts.Herc1155.ContractInstance;
  using MediatR;
  using P9Control.Api.Constants.AccountAddresses;
  using System.Collections.Generic;
  using P9Control.Api.Features.WebThree.Contracts.Herc1155.BalanceOf;

  public class BalanceOfServiceHandler : IRequestHandler<BalanceOfServiceRequest, BalanceOfServiceResponse>
  {
    Herc1155Instance Herc1155Instance { get; set; }

    public BalanceOfServiceHandler(Herc1155Instance aHerc1155Instance)
    {
      Herc1155Instance = aHerc1155Instance;
    }
    public async Task<BalanceOfServiceResponse> Handle(BalanceOfServiceRequest aBalanceOfServiceRequest, CancellationToken aCancellationToken)
    {
      Function<BalanceOfFunctionInput> aBalanceOfFunction = Herc1155Instance.Instance.GetFunction<BalanceOfFunctionInput>();

     int response = await aBalanceOfFunction.CallAsync<int>(
        new BalanceOfFunctionInput
        {
          TokenOwner = TestEthAccounts.TestEthAccountAddress,
          TokenId = aBalanceOfServiceRequest.TokenId
        }
        );

      return new BalanceOfServiceResponse
      {
      Balance = response
      };

    }
  }
}


