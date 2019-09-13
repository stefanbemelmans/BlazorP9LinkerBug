namespace P9Control.Client.Features.WebThree.Components.NftTemplates
{
  using P9Control.Api.Features.WebThree;
  using P9Control.Client.Features.WebThree.Components.NftTemplates.PurchaseOrder;

  public class TokenBase

  {
    public int Balance { get; set; }
    public string Data { get; set; }

    // Changing Object to ImmutableObjectBase that contains the Immutable DataProperty
    public ImmutableObjectBase DataObject { get; set; }

    public string MutableData { get; set; }
    public uint NftId { get; set; }
    public PurchaseOrderData PurchaseOrderData { get; set; }
    public NftTemplate TemplateData { get; set; }
    public uint TokenId { get; set; }
  }
}