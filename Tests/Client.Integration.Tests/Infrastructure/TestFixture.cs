namespace P9Control.Client.Integration.Tests.Infrastructure
{
  using P9Control.Client;
  using P9Control.Client.Features.Application;
  using P9Control.Client.Features.Counter;
  using P9Control.Client.Features.EventStream;
  using P9Control.Client.Features.WeatherForecast;
  using P9Control.Client.Features.ClientLoaderFeature;
  using BlazorState;
  using Microsoft.AspNetCore.Blazor.Hosting;
  using Microsoft.Extensions.DependencyInjection;
  using System;
  using System.Reflection;
  using System.Text.Json;

  /// <summary>
  /// A known starting state(baseline) for all tests.
  /// And Common set of functions
  /// </summary>
  public class TestFixture//: IMediatorFixture, IStoreFixture, IServiceProviderFixture
  {
    /// <summary>
    /// This is the ServiceProvider that will be used by the Client
    /// </summary>
    public IServiceProvider ServiceProvider => WebAssemblyHostBuilder.Build().Services;

    public IWebAssemblyHostBuilder WebAssemblyHostBuilder { get; }

    private TestServer BlazorStateTestServer { get; }

    public TestFixture(TestServer aBlazorStateTestServer)
    {
      BlazorStateTestServer = aBlazorStateTestServer;
      WebAssemblyHostBuilder = BlazorWebAssemblyHost.CreateDefaultBuilder()
          .ConfigureServices(ConfigureServices);
    }

    /// <summary>
    /// Special configuration for Testing with the Test Server
    /// </summary>
    /// <param name="aServiceCollection"></param>
    private void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddSingleton(BlazorStateTestServer.CreateClient());
      aServiceCollection.AddBlazorState
      (
        aOptions => aOptions.Assemblies =
        new Assembly[] { typeof(Startup).GetTypeInfo().Assembly }
      );

      aServiceCollection.AddSingleton
      (
        new JsonSerializerOptions
        {
          PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }
      );

      aServiceCollection.AddSingleton<IClientLoaderConfiguration, ClientLoaderTestConfiguration>();
      aServiceCollection.AddTransient<ApplicationState>();
      aServiceCollection.AddTransient<CounterState>();
      aServiceCollection.AddTransient<EventStreamState>();
      aServiceCollection.AddTransient<WeatherForecastsState>();
    }
  }
}