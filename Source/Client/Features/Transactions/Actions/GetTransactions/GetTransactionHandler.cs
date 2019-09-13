namespace P9Control.Client.Features.Transactions
{
  using BlazorState;
  using P9Control.Client.Features.Base;
  using System.Collections.Generic;
  using System.Net.Http;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class TransactionState
  {
    internal class GetTransactionHandler : BaseHandler<GetTransactionAction, TransactionState>
    {
      public GetTransactionHandler(IStore aStore, HttpClient aHttpClient) : base(aStore)
      {
        HttpClient = aHttpClient;
      }

      public HttpClient HttpClient { get; }

      private TransactionState TransactionState => Store.GetState<TransactionState>();

      public override Task<TransactionState> Handle
      (
        GetTransactionAction aGetTransactionAction,
        CancellationToken aCancellationToken
      )
      {
        var tX1 = new Transaction();
        var tX2 = new Transaction { Amount = ".0034234053234", OtherData = "TX2 Other Data", TxHash = "TX2 Hash" };
        var tX3 = new Transaction { Amount = "5.842674", OtherData = "TX3 Other Data", TxHash = "TX3 Hash" };

        var txList = new List<Transaction>
        {
          tX1,
          tX2,
          tX3
        };
        TransactionList = txList;
        return Task.FromResult(TransactionState);
      }
    }
  }
}