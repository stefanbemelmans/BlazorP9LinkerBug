﻿namespace P9Control.Server
{
  using MediatR;
  using Microsoft.AspNetCore.Builder;
  using Microsoft.AspNetCore.Hosting;
  using Microsoft.AspNetCore.ResponseCompression;
  using Microsoft.Extensions.DependencyInjection;
  using Microsoft.Extensions.Hosting;
  using System.Linq;
  using P9Control.Api.Constants.AccountAddresses;
  using P9Control.Api.Constants.WebThree;
  using System.Net.Mime;
  using System.Reflection;
  using Nethereum.Web3;
  using Nethereum.Contracts;
  using P9Control.Api.Constants;
  using P9Control.Server.Services.WebThree.Contracts.NftCreator.ContractInstance;
  using P9Control.Server.Services.WebThree.Instance;
  using P9Control.Server.Services.WebThree.Contracts.Herc1155.ContractInstance;

  using BlazorState;

  public class Startup
  {
    public void Configure
    (
      IApplicationBuilder aApplicationBuilder,
      IWebHostEnvironment aWebHostEnvironment
    )
    {
      aApplicationBuilder.UseResponseCompression();

      if (aWebHostEnvironment.IsDevelopment())
      {
        aApplicationBuilder.UseDeveloperExceptionPage();
        aApplicationBuilder.UseBlazorDebugging();
      }

      aApplicationBuilder.UseRouting();
      aApplicationBuilder.UseEndpoints
      (
        aEndpointRouteBuilder =>
        {
          aEndpointRouteBuilder.MapControllers(); // We use explicit attribute routing so dont need MapDefaultControllerRoute
          aEndpointRouteBuilder.MapBlazorHub();
          aEndpointRouteBuilder.MapFallbackToPage("/_Host");
        }
      );
      aApplicationBuilder.UseClientSideBlazorFiles<Client.Startup>();
    }

    public void ConfigureServices(IServiceCollection aServiceCollection)
    {
      aServiceCollection.AddRazorPages();
      aServiceCollection.AddServerSideBlazor();
      aServiceCollection.AddMvc();

      aServiceCollection.AddResponseCompression
      (
        aResponseCompressionOptions =>
          aResponseCompressionOptions.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat
          (
            new[] { MediaTypeNames.Application.Octet }
          )
      );

      aServiceCollection.AddSingleton<NethWeb3>();
      aServiceCollection.AddScoped<NftCreatorInstance>();
      aServiceCollection.AddScoped<Herc1155Instance>();
      new Client.Startup().ConfigureServices(aServiceCollection);

      aServiceCollection.AddMediatR(typeof(Startup).GetTypeInfo().Assembly);

      aServiceCollection.Scan
      (
        aTypeSourceSelector => aTypeSourceSelector
          .FromAssemblyOf<Startup>()
          .AddClasses()
          .AsSelf()
          .WithScopedLifetime()
      );
    }
  }
}