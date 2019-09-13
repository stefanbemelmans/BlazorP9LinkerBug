namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.AddNewTemplate
{   // [Function("name", "return type")]
    using Nethereum.ABI.FunctionEncoding.Attributes;
    using Nethereum.Contracts;
    using System.Numerics;

    // Create a new NFT Template 
    // This Works
    //[Function(name: "AddNFTTemplate")]
    [Function(name: "CreateTemplate")]
    public class AddNewTemplateFunctionInput : FunctionMessage
    {
        [Parameter(type: "string", name: "name", 1)]
        public string NewTemplateName { get; set; }

        [Parameter("string", "symbol", 2)]
        public string NewTemplateSymbol { get; set; }

        [Parameter("uint", "mintlimit", 3)]
        public BigInteger NewTemplateMintLimit { get; set; }

        [Parameter("uint", "attachedtokens", 4)]
        public BigInteger NewTemplateAttachedTokens { get; set; }

    }
}
