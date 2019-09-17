namespace P9Control.Client.Features.WebThree
{ 
    using MediatR;
    using P9Control.Api.Constants.AccountAddresses;
    using P9Control.Api.Features.Base;

    public class GetAllOwnedTokensAction : BaseRequest, IRequest<OwnedNftState>
    {
        public const string TokenOwner = TestEthAccounts.TestEthAccountAddress;
    }
}
