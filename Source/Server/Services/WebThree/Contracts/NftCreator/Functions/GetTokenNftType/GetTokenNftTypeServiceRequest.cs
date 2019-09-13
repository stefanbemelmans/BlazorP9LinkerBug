namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.GetTokenNftType
{
  using MediatR;
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using Nethereum.Contracts;

  
  [Function(name: "tokenType")]
  public class GetTokenNftTypeServiceRequest : FunctionMessage, IRequest<GetTokenNftTypeServiceResponse>
  {
    [Parameter(type: "uint")]
    public uint TokenId { get; set; }
  }
}
