namespace P9Control.Client.Features.WebThree.Components.NftTemplates.PurchaseOrder
{
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree.Actions.AddFormDataToState;
  using System;

  public class PurchaseOrderData : ImmutableObjectBase
  {
    public string Approver { get; set; }

    public DateTime DeliveryDate { get; set; } = DateTime.Now;

    public string Department { get; set; }

    public string Item_Code { get; set; }

    public int Item_Discount { get; set; }

    public string Item_Name { get; set; }

    public string Item_Price { get; set; }

    public int Item_Qty { get; set; }

    public int Item_Total { get; set; }

    public string Notes { get; set; }

    public string Requester { get; set; }
  }

  public class PurchaseOrderTemplateBase : BaseComponent
  {
#pragma warning disable CA1051 // Do not declare visible instance fields
    public PurchaseOrderData FormData = new PurchaseOrderData();
#pragma warning restore CA1051 // Do not declare visible instance fields

    public string MutableDataString { get; set; }

    public PurchaseOrderTemplateBase()
    {
      FormData.Title = "Purchase Order";
    }

    public void ConsoleData()
    {
      Console.WriteLine("Trying to Console...empty?");
      foreach (System.Reflection.PropertyInfo prop in FormData.GetType().GetProperties())
      {
        Console.WriteLine($"{prop.Name}: {prop.GetValue(FormData)}");
      }
    }

    public async void SendDataToState()
    {
      ConsoleData();
      WebThreeState response = await Mediator.Send(new AddFormDataToStateAction()
      {
        FormObjectValues = FormData,
        MutableDataString = MutableDataString
      });
    }
  }
}