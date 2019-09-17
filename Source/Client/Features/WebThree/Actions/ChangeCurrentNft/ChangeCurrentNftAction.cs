namespace P9Control.Client.Features.WebThree
{ 
  using MediatR;
  using P9Control.Api.Features.Base;
  public class ChangeCurrentNftAction : BaseRequest, IRequest<OwnedNftState>
  {
    public string TemplateName { get; set; }
  }
}