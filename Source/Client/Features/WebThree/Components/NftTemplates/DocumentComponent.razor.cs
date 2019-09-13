namespace P9Control.Client.Features.WebThree.Components.NftTemplates
{
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree.Components.NftTemplates.PurchaseOrder;
  using P9Control.Client.Features.WebThree.Components.NftTemplates.BillOfLading;
  using P9Control.Client.Features.WebThree.Components.NftTemplates.PurchaseRequest;
  using P9Control.Client.Features.WebThree.Components.NftTemplates.RequestForProposal;
  using P9Control.Client.Features.WebThree.Components.NftTemplates.RequestForQuotation;

  public class DocumentComponentBase : BaseComponent
  {
    [Parameter]
    public uint NftId { get; set; }
    public PurchaseOrderTemplate PurchaseOrderTemplate { get; set; } = new PurchaseOrderTemplate();

    public BillOfLadingTemplate BillOfLadingTemplate { get; set; } = new BillOfLadingTemplate();

    public PurchaseRequestTemplate PurchaseRequestTemplate { get; set; } = new PurchaseRequestTemplate();

    public RequestForProposalTemplate RequestForProposalTemplate { get; set; } = new RequestForProposalTemplate();

    public RequestForQuotationTemplate RequestForQuotoationTemplate { get; set; } = new RequestForQuotationTemplate();


  }
}
