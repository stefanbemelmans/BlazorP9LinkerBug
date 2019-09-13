namespace P9Control.Client.Features.WebThree.Components
{
    using P9Control.Api.Features.WebThree;
    using P9Control.Client.Features.Base.Components;
    using Microsoft.AspNetCore.Components;
    using P9Control.Client.Features.WebThree.Components.NftTemplates;
    using System.Collections.Generic;
    using P9Control.Client.Features.WebThree.Actions.ChangeCurrentToken;

    public class TokenInfoBase : BaseComponent
    {
       [Parameter]
    public TokenBase CurrentTokenData { get; set; }
        

        //public void SetNewToken(ChangeEventArgs eventArgs)
        //{
        //    string TokenId = eventArgs.Value.ToString();

        //    Mediator.Send(new ChangeCurrentTokenAction() { TokenId = int.Parse(TokenId) });
        //}

        //protected override async Task OnInitAsync()
        //{
        //    var TokenData = await Mediator.Send(new GetAllOwnedTokensAction());
        //    CurrentTokenData = TokenDataList[0];
        //    CurrentTokenId = TokenDataList[0].TokenId;
        //    CurrentTokenNftType = TokenDataList[0].TemplateData;
        //    //WebThreeState.CurrentTokenNftType = TokenDataList[0].TemplateData.NftId;
        //}
    }

}