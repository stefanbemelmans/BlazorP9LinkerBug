namespace P9Control.Api.Features.WebThree
{
    public class NftTemplate
    {
        public uint NftId { get; set; }
        public string Name { get; set; }

        public string Symbol { get; set; }

        public int MintLimit { get; set; }

        public int AttachedTokens { get; set; }
    }
}
