namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.GetTokenNftType
{
  using System.Threading.Tasks;
  using System.Threading;
  using Nethereum.Contracts;
  using P9Control.Server.Services.WebThree.Contracts.NftCreator.ContractInstance;
  using MediatR;

  public class GetTokenNftTypeServerServiceHandler : IRequestHandler<GetTokenNftTypeServiceRequest, GetTokenNftTypeServiceResponse>
    {
    NftCreatorInstance NftCreator { get; set; }

    public GetTokenNftTypeServerServiceHandler(NftCreatorInstance aNftCreatorInstance)
    {
      NftCreator = aNftCreatorInstance;
    }

    public async Task<GetTokenNftTypeServiceResponse> Handle(GetTokenNftTypeServiceRequest aGetTokenNftTypeServiceRequest, CancellationToken aCancellationToken)
    {
      Function tokenTypeFunction = NftCreator.Instance.GetFunction("tokenType");

      uint tokenType = await tokenTypeFunction.CallAsync<uint>(aGetTokenNftTypeServiceRequest.TokenId);
        

      return new GetTokenNftTypeServiceResponse { NftId = (uint)tokenType };
    }
  }
}


