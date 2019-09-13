namespace P9Control.Client.Layout
{
  using MediatR;
  using Microsoft.AspNetCore.Components;

  public class AssetNftLayoutBase :  LayoutComponentBase 
  {
    [Inject]
    IMediator Mediator { get; set; }

    //protected override async Task OnAfterRenderAsync()
    //{
      // Are we in the proper state for this page?

     //await mediator.Send(new GetNftTypesClient.FeaturesAction());
      


  }
}
