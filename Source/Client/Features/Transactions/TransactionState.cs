namespace P9Control.Client.Features.Transactions
{
  using BlazorState;
  using System.Collections.Generic;

  public class Transaction
  {
    public string Amount { get; set; } = "0.21045934234023";
    public string OtherData { get; set; } = "Other TX1 Data";
    public string TxHash { get; set; } = "TX1 Hash";
  }

  internal partial class TransactionState : State<TransactionState>
  {
    public static List<Transaction> TransactionList { get; set; }
    public int HercId { get; set; }

    public TransactionState()
    {
      TransactionList = new List<Transaction>();
    }

    /// <summary>
    /// Set the Initial State
    /// </summary>
    protected override void Initialize() => HercId = 42;
  }
}