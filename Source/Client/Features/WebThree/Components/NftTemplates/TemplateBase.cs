namespace P9Control.Client.Features.WebThree.Components.NftTemplates
{
    public class TemplateBase
    {

        public TemplateBase() { }
        // NftId This will get assigned after creation
        public uint NftId { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public uint MintLimit { get; set; }
        public uint AttachedTokens { get; set; }

    }
}
