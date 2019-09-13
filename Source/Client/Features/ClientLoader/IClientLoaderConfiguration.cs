namespace P9Control.Client.Features.ClientLoaderFeature
{
  using System;

  public interface IClientLoaderConfiguration
  {
    TimeSpan DelayTimeSpan { get; }
  }
}
