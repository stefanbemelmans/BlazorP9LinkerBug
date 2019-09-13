namespace P9Control.Client.Features.Transactions
{
  using MediatR;
  using P9Control.Api.Features.Base;
  

  public class GetTransactionAction : BaseRequest, IRequest<TransactionState>
  {
    
  }
}