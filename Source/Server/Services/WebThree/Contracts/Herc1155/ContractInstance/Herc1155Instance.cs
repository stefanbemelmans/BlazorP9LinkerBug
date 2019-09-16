namespace P9Control.Server.Services.WebThree.Contracts.Herc1155.ContractInstance
{
  using Nethereum.Contracts;
  using P9Control.Server.Services.WebThree.Instance;
  using P9Control.Api.Constants.ContractConstants.Herc1155;
  //using P9Control.Api.Constants.ContractConstants.Herc1155;
  public class Herc1155Instance
    {
      NethWeb3 NethWeb3 { get; set; }
      public Contract Instance { get; set; }
    
    //static StreamReader reader = new StreamReader(@"C:\mv\NewTimewarpTemplate\P9Control\Source\P9Control.Shared\Constants\ContractConstants\Herc1155\Abi.json");
    
      //readonly string NftCreatorAbi = reader.ReadToEnd();
      public Herc1155Instance(NethWeb3 aNethWeb3)
      {
        NethWeb3 = aNethWeb3;
        Instance = NethWeb3.Instance.Eth.GetContract(Herc115520Abi.Abi, Herc115520Addresses.RopstenAddress);
    }
  }

}


