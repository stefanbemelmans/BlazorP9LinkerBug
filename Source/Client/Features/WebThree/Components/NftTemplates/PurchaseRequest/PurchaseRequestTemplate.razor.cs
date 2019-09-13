namespace P9Control.Client.Features.WebThree.Components.NftTemplates.PurchaseRequest
{
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree.Actions.AddFormDataToState;
  using System;

  public class PurchaseRequestTemplateBase : BaseComponent
  {
    [Parameter]
    public PurchaseRequestData FormData { get; set; } = new  PurchaseRequestData();
    
    public string MutableDataString { get; set; }

    public PurchaseRequestTemplateBase()
    {
      FormData.Title = "Purchase Request";
    }

    public async void SendDataToState()
    {
      ConsoleData();
      WebThreeState response = await Mediator.Send(new AddFormDataToStateAction()
      {
        FormObjectValues = FormData,
        MutableDataString = MutableDataString
      });

      WebThreeState.ImmutableObject = response.ImmutableObject;
      WebThreeState.MutableDataString = response.MutableDataString;

     
    }

    public void ConsoleData()
    {
      Console.WriteLine("Trying to Console...empty?");
      foreach (System.Reflection.PropertyInfo prop in FormData.GetType().GetProperties())
      {
        Console.WriteLine($"{prop.Name}: {prop.GetValue(FormData)}");
      }
    }
  }
  public class PurchaseRequestData : ImmutableObjectBase
  {
    public int StockNumber { get; set; }
    public string Description { get; set; }
    public int Qty { get; set; }
    public int UnitPrice { get; set; }
    public int ExtendedCost { get; set; }
    public DateTime Date { get; set; }
    public string Requester { get; set; }
    public string Department { get; set; }
    public string ChargeTo { get; set; }
    public string Vendor { get; set; }
    public string VendorAddress { get; set; }
    public string VendorContact { get; set; }
    public string Phone { get; set; }
    public DateTime DateNeeded { get; set; }
    public string ShipVia { get; set; }
  }
}