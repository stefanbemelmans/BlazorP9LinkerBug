namespace P9Control.Client.Features.WebThree.Components
{
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using P9Control.Client.Features.Base.Components;

  public class FormConfirmationComponentBase : BaseComponent
  {
    [Parameter]
   public ImmutableObjectBase FormData { get; set; }

    [Parameter]
    public string MutableDataString { get; set; }


  }
}
