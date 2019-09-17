namespace P9Control.Client.Features.WebThree.Actions.ViewTokenData
{
    using MediatR;
    public class ViewTokenDataAction : IRequest<OwnedNftState>
    {
        public uint TokenIdToGet { get; set; }
    }
}
