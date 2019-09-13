﻿namespace P9Control.Client.Features.EventStream
{
  using P9Control.Api.Features.Base;
  using MediatR;
  using Microsoft.Extensions.Logging;
  using System;
  using System.Threading;
  using System.Threading.Tasks;

  /// <summary>
  /// Every event that comes through the pipeline adds an object to the EventStreamState
  /// </summary>
  /// <typeparam name="TRequest"></typeparam>
  /// <typeparam name="TResponse"></typeparam>
  /// <remarks>To avoid infinite recursion don't add AddEvent to the event stream</remarks>
  public class EventStreamBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
  {
    private readonly ILogger Logger;
    private readonly IMediator Mediator;
    public Guid Guid { get; } = Guid.NewGuid();

    public EventStreamBehavior
                (
      ILogger<EventStreamBehavior<TRequest, TResponse>> aLogger,
      IMediator aMediator
    )
    {
      Logger = aLogger;
      Mediator = aMediator;
      Logger.LogDebug($"{GetType().Name}: Constructor");
    }

    public async Task<TResponse> Handle
    (
      TRequest aRequest,
      CancellationToken aCancellationToken,
      RequestHandlerDelegate<TResponse> aNext
    )
    {
      if (aNext is null)
      {
        throw new ArgumentNullException(nameof(aNext));
      }

      await AddEventToStream(aRequest, "Start");
      TResponse newState = await aNext();
      await AddEventToStream(aRequest, "Completed");
      return newState;
    }

    private async Task AddEventToStream(TRequest aRequest, string aTag)
    {
      if (!(aRequest is AddEventAction)) //Skip to avoid recursion
      {
        var addEventAction = new AddEventAction();
        string requestTypeName = aRequest.GetType().Name;

        if (aRequest is BaseRequest request)
        {
          addEventAction.Message = $"{aTag}:{requestTypeName}:{request.Id}";
        }
        else
        {
          addEventAction.Message = $"{aTag}:{requestTypeName}";
        }
        await Mediator.Send(addEventAction);
      }
    }
  }
}