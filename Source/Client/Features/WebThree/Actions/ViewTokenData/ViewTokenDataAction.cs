namespace P9Control.Client.Features.WebThree.Actions.ViewTokenData
{
    using MediatR;
    public class ViewTokenDataAction : IRequest<WebThreeState>
    {
        public uint TokenIdToGet { get; set; }
    }
}
