namespace P9Control.Api.Features.WebThree.Contracts.NftCreator.AddNewTemplate
{
  using P9Control.Api.Features.Base;
  using MediatR;
  using P9Control.Api.Features.WebThree.Contracts.NftCreator.GetNftByType;

  public class AddNewTemplateSharedRequest : BaseRequest, IRequest<AddNewTemplateSharedResponse>
  {
    public const string Route = "api/AddNewTemplate";

    //public static string RouteFactory(int aId) => $"api/AddNewTemplate?MintNftType={aId}";
    public string NewTemplateName { get; set; }
    public string NewTemplateSymbol { get; set; }
    public uint  NewTemplateMintLimit { get; set; }
    public uint NewTemplateAttachedTokens { get; set; }
  }

}
