namespace P9Control.Client.Features.Transactions.Components
{
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.Transactions;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  public class TransactionListBase : BaseComponent
  {
    public List<Transaction> TransactionList => TransactionState.TransactionList;
    protected async Task GetTransactions() =>
      _ = await Mediator.Send(new GetTransactionAction());
  }
}