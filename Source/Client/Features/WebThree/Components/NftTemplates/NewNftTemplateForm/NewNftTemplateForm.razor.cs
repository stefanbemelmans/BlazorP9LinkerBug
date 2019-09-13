namespace P9Control.Client.Features.WebThree.Components
{
    using Microsoft.AspNetCore.Components;
    using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using P9Control.Api.Features.WebThree;

  public class NewNftTemplateFormBase : BaseComponent
    {
        [Parameter]
      public NftTemplate NewTemplateForm { get; set; } 

    }
}