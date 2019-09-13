namespace P9Control.Client.Features.WebThree.Actions.GetAllOwnedTokens
{
    using MediatR;
    using P9Control.Api.Constants.AccountAddresses;
    using P9Control.Api.Features.Base;

    public class GetAllOwnedTokensAction : BaseRequest, IRequest<WebThreeState>
    {
        public const string TokenOwner = TestEthAccounts.TestEthAccountAddress;
    }
}
