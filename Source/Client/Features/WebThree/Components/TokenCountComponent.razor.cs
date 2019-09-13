namespace P9Control.Client.Features.WebThree.Components
{
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree.Actions.ChangeCurrentToken;
  using Microsoft.AspNetCore.Components;
  using System.Collections.Generic;

  public class TokenCountComponentBase : BaseComponent
  {
    [Parameter]
    public List<uint> OwnedTokenIdList { get; set; }

    public void SetNewToken(ChangeEventArgs eventArgs)
    {
      if (eventArgs != null)
      {
        string TokenId = eventArgs.Value.ToString();
        Mediator.Send(new ChangeCurrentTokenAction() { TokenId = int.Parse(TokenId) });
      }
    }
  }
}