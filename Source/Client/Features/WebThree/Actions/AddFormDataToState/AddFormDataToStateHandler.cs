namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.AddFormDataToState;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class WebThreeState
  {
    public class AddFormDataToStateHandler : BaseHandler<AddFormDataToStateAction, WebThreeState>
    {
      public AddFormDataToStateHandler(IStore aStore) : base(aStore) { }

      public override Task<WebThreeState> Handle
        (
        AddFormDataToStateAction aAddFormDataToStateRequest,
        CancellationToken aCancellationToken
        )
      {
        WebThreeState WebThreeState = Store.GetState<WebThreeState>();
        ImmutableObjectBase formValues = aAddFormDataToStateRequest.FormObjectValues;

        WebThreeState.MutableDataString = aAddFormDataToStateRequest.MutableDataString;
        WebThreeState.ImmutableObject = formValues;

        
        return Task.FromResult(WebThreeState);

      }
    }
  }
}