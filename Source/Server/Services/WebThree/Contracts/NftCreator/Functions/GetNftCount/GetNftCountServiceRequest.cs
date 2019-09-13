namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftCount
{
  using MediatR;
  using Nethereum.ABI.FunctionEncoding.Attributes;

  [Function(name: "totalNFTs")]
  public class GetNftCountServiceRequest : IRequest<GetNftCountServiceResponse>
    {
    
    }
}
