namespace P9Control.Server.Services.WebThree.Contracts.Herc1155
{   // [Event("event name")]
    using Nethereum.ABI.FunctionEncoding.Attributes;
    using System.Numerics;

    // this is an event that is emitted by HERC1155 as result of the NftCreator Mint function

    [Event("TransferSingle")]
    public class MintNftOutputEventDto : IEventDTO
    {
        [Parameter(type: "address", name: "_operater", order: 1, indexed: true)]
        public string Operator { get; set; }

        [Parameter("address", "_from", 2, true)]
        public string From { get; set; }

        [Parameter("address", "_to", 3, true)]
        public string To { get; set; }

        [Parameter("uint256", "_id", 4, false)]
        public BigInteger Id { get; set; }

        [Parameter("uint256", "_value", 4, false)]
        public BigInteger Value { get; set; }

    }
}
