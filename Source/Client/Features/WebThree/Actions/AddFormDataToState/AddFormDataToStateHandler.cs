namespace P9Control.Client.Features.WebThree.Actions
{
  using BlazorState;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.AddFormDataToState;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class OwnedNftState
  {
    public class AddFormDataToStateHandler : BaseHandler<AddFormDataToStateAction, OwnedNftState>
    {
      public AddFormDataToStateHandler(IStore aStore) : base(aStore) { }

      public override Task<OwnedNftState> Handle
        (
        AddFormDataToStateAction aAddFormDataToStateRequest,
        CancellationToken aCancellationToken
        )
      {
        OwnedNftState WebThreeState = Store.GetState<OwnedNftState>();
        ImmutableObjectBase formValues = aAddFormDataToStateRequest.FormObjectValues;

        WebThreeState.MutableDataString = aAddFormDataToStateRequest.MutableDataString;
        WebThreeState.ImmutableObject = formValues;

        
        return Task.FromResult(WebThreeState);

      }
    }
  }
}