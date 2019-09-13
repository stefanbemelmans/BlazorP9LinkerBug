namespace P9Control.Client.Features.WebThree.Components
{
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree.Actions.ChangeCurrentNft;
  using P9Control.Api.Features.WebThree;
  using System;
  using System.Collections.Generic;

  public class NftTypeListComponentBase : BaseComponent
  {
    public NftTemplate CurrentNftTemplate
    {
      get => WebThreeState.CurrentNftTemplate;
      set { }
    }

    public List<NftTemplate> NftDataList => WebThreeState.TemplateDataList;

    public void SetNewNft(ChangeEventArgs aEventArgs)
    {
      if (aEventArgs != null)
      {
        string templateName = aEventArgs.Value.ToString();

        Console.WriteLine(templateName);
        Mediator.Send(new ChangeCurrentNftAction() { TemplateName = templateName });
      }
    }
  }
}