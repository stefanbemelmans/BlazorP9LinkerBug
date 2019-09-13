namespace P9Control.Server.Features.WebThree.Contracts.NftCreator.AddNewTemplate
{
  using MediatR;
  using P9Control.Server.Services.WebThree.Contracts.NftCreator.AddNewTemplate;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.AddNewTemplate;
  using System.Threading;
  using System.Threading.Tasks;

  public class AddNewTemplateServerFeaturesHandler : IRequestHandler<AddNewTemplateSharedRequest, AddNewTemplateSharedResponse>
  {
    IMediator Mediator { get; set; }

    public AddNewTemplateServerFeaturesHandler(IMediator aMediator)
    {
      Mediator = aMediator;
    }
    
    public async Task<AddNewTemplateSharedResponse> Handle
    (
      AddNewTemplateSharedRequest aAddNewTemplateSharedRequest,
      CancellationToken aCancellationToken
    )
    {
      var aNewTemplateServiceRequest = new AddNewTemplateServiceRequest
      {
        NewTemplateName = aAddNewTemplateSharedRequest.NewTemplateName,
        NewTemplateSymbol = aAddNewTemplateSharedRequest.NewTemplateSymbol,
        NewTemplateMintLimit = aAddNewTemplateSharedRequest.NewTemplateMintLimit,
        NewTemplateAttachedTokens = aAddNewTemplateSharedRequest.NewTemplateAttachedTokens
      };

      AddNewTemplateServiceResponse response = await Mediator.Send(aNewTemplateServiceRequest);

      return new AddNewTemplateSharedResponse
      {
        NewTemplateTransactionReceipt = response.NewTemplateTransactionReceipt
      };
    }
  }
}