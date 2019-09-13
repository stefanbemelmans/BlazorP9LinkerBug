namespace P9Control.Client.Features.Counter
{
  using MediatR;
  using Microsoft.Extensions.Logging;
  using P9Control.Client.Features.Transactions;
  using P9Control.Client.Pipeline.NotificationPostProcessor;
  using System.Threading;
  using System.Threading.Tasks;

  internal class GetTransactionNotificationHandler
    : INotificationHandler<PostPipelineNotification<GetTransactionAction, TransactionState>>
  {
    private readonly ILogger Logger;

    public GetTransactionNotificationHandler(ILogger<GetTransactionNotificationHandler> aLogger)
    {
      Logger = aLogger;
    }

    public Task Handle
    (
      PostPipelineNotification<GetTransactionAction, TransactionState> aPostPipelineNotification,
      CancellationToken aCancellationToken
    )
    {
      Logger.LogDebug(aPostPipelineNotification.Request.GetType().Name);
      Logger.LogDebug($"{nameof(GetTransactionNotificationHandler)} handled");
      return Task.CompletedTask;
    }
  }
}