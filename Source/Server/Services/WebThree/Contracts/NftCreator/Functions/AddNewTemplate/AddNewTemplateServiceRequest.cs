namespace P9Control.Server.Services.WebThree.Contracts.NftCreator.AddNewTemplate
{
  using MediatR;
  using P9Control.Api.Features.WebThree;
  

  public class AddNewTemplateServiceRequest : IRequest<AddNewTemplateServiceResponse>
    {
    public string NewTemplateName { get; set; }
    public string NewTemplateSymbol { get; set; }
    public uint NewTemplateMintLimit { get; set; }
    public uint NewTemplateAttachedTokens { get; set; }
  }
}
