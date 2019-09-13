namespace P9Control.Server.Services.WebThree.Instance
{
    
  using Nethereum.Web3;
  using P9Control.Api.Constants.AccountAddresses;
  using P9Control.Api.Constants.WebThree;

  public class NethWeb3
  {
    public NethWeb3()
    {
      Instance = new Web3(testAccount.TesterAcct, Web3Endpoints.RopstenEndpoint);
    }

    public Web3 Instance { get; set; }
    public TestEthAccounts testAccount = new TestEthAccounts();
  }

}
