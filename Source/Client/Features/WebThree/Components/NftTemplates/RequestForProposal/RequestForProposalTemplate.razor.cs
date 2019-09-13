namespace P9Control.Client.Features.WebThree.Components.NftTemplates.RequestForProposal
{
  using Microsoft.AspNetCore.Components;
  using P9Control.Client.Features.Base.Components;
  using P9Control.Client.Features.WebThree.Actions.AddFormDataToState;
  using System;

  public class RequestForProposalTemplateBase : BaseComponent
  {
    [Parameter]
    public RequestForProposalData FormData { get; set; } = new RequestForProposalData();

    public string MutableDataString { get; set; }

    public RequestForProposalTemplateBase()
    {
      FormData.Title = "Request For Proposal";
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

      WebThreeState.ImmutableObject = response.ImmutableObject;
      WebThreeState.MutableDataString = response.MutableDataString;
    }
  }
  public class RequestForProposalData : ImmutableObjectBase
  {
    public string AcceptanceCriteria { get; set; }
    public string AddressParcel { get; set; }
    public string Budget { get; set; }
    public string CompanyName { get; set; }
    public string ContactEmail { get; set; }
    public string Deadline { get; set; }
    public string EquivalentSubstitution { get; set; }
    public string ModeOfTransport { get; set; }
    public string Requirement { get; set; }
  }
}