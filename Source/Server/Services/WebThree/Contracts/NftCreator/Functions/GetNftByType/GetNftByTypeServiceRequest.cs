namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.GetNftByType
{
  using MediatR;
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftByType;
  [Function(name: "NFTTemplates")]
  public class GetNftByTypeServiceRequest : IRequest<GetNftByTypeServiceResponse>
  {
    [Parameter(type: "uint", name: "id", order: 1)]
    public uint GetNftId { get; set; }
    
    }
}
