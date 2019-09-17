namespace P9Control.Client.Features.WebThree
{ 
  using MediatR;
  using P9Control.Client.Features.WebThree.Components.NftTemplates;

  public class AddFormDataToStateAction : IRequest<OwnedNftState>
  {
    public ImmutableObjectBase FormObjectValues { get; set; }
    public string MutableDataString { get; set; }
  }
}
