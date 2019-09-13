namespace P9Control.Server.Services.WebThree.Contracts.Herc1155.GetAllOwnedTokens
{
  using MediatR;

  public class GetAllOwnedTokensServiceRequest : IRequest<GetAllOwnedTokensServiceResponse>
    {
    public string TokenOwner { get; set; }
    }
}
