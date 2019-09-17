namespace P9Control.Client.Features.WebThree
{
  using BlazorState;
  using P9Control.Client.Features.Base;
  using P9Control.Client.Features.WebThree.Actions.AddFormDataToState;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;
  using System.Threading;
  using System.Threading.Tasks;

  internal partial class MintNftState : State<MintNftState>
  {
    public class AddFormDataToStateHandler : BaseHandler<AddFormDataToStateAction, MintNftState>
    {
      public AddFormDataToStateHandler(IStore aStore) : base(aStore) { }

      public override Task<MintNftState> Handle
        (
        AddFormDataToStateAction aAddFormDataToStateRequest,
        CancellationToken aCancellationToken
        )
      {
        MintNftState MintNftState = Store.GetState<MintNftState>();
        ImmutableObjectBase formValues = aAddFormDataToStateRequest.FormObjectValues;

        MintNftState.MutableDataString = aAddFormDataToStateRequest.MutableDataString;
        MintNftState.ImmutableObject = formValues;

        
        return Task.FromResult(MintNftState);

      }
    }
  }
}