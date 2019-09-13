namespace P9Control.EndToEnd.Tests.Infrastructure
{
  using P9Control.Client.Features.ClientLoaderFeature;
  using System;

  public class TestClientLoaderConfiguration : IClientLoaderConfiguration
  {
    public TimeSpan DelayTimeSpan => TimeSpan.FromMilliseconds(10);
  }
}
