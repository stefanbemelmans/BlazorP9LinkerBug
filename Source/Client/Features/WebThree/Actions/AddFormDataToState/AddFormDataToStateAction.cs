namespace P9Control.Client.Features.WebThree.Actions.AddFormDataToState
{
  using MediatR;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;

  public class AddFormDataToStateAction : IRequest<WebThreeState>
  {
    public ImmutableObjectBase FormObjectValues { get; set; }
    public string MutableDataString { get; set; }
  }
}
