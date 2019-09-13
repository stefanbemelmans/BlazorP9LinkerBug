namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.Functions.MintNftOfType
{
  using MediatR;
  using System.Collections.Generic;

  public class MintNftOfTypeServiceRequest : IRequest<MintNftOfTypeServiceResponse>
    {
    public int MintNftId { get; set; }

    public string ImmutableDataString { get; set; }

    public string MutableDataString { get; set; }
    
    }
}
