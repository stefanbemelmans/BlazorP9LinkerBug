namespace P9Control.Api.Features.AnySerializer
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using global::AnySerializer;
  using P9Control.Api.Features.AnySerializer.NftDataTypes.PurchaseOrder;

  public class NftTypeSerializer
  {
    public uint NftId { get; set; }


    private void DeserializeData(uint nft, string aDataString)
    {
      if (nft == 1)
      {
        byte[] serializedImmutableData = Convert.FromBase64String(aDataString);

        PurchaseOrderData aDeserializedObject = Serializer.Deserialize<PurchaseOrderData>(serializedImmutableData, options); // options == 0

        aOwnedToken.PurchaseOrderData = aDeserializedObject;

        // Add to StateList
        TokenDataList.Add(aOwnedToken);
      }
      else
      {
        aOwnedToken.Data = aDataString;

        TokenDataList.Add(aOwnedToken);
      }
    }
  }
}
