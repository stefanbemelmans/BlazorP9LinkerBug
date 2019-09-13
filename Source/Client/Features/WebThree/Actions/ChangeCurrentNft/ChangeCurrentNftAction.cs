namespace P9Control.Client.Features.WebThree.Actions.ChangeCurrentNft
{
  using MediatR;
  using P9Control.Api.Features.Base;
  using P9Control.Api.Features.WebThree;
  public class ChangeCurrentNftAction : BaseRequest, IRequest<WebThreeState>
  {
    public string TemplateName { get; set; }
  }
}