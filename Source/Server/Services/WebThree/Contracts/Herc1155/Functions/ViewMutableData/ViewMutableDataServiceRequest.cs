namespace P9Control.Server.Services.WebThree.Contracts.Herc1155
{
  using MediatR;
  using Nethereum.ABI.FunctionEncoding.Attributes;
  using Nethereum.Contracts;

  [Function(name: "viewMutableData")]
  public class ViewMutableDataServiceRequest : FunctionMessage, IRequest<ViewMutableDataServiceResponse>
  {
    public uint ViewTokenId { get; set; }
  }
}