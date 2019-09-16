//namespace P9Control.Api.Features.AnySerializer
//{
//  using System;
//  using System.Collections.Generic;
//  using System.Linq;
//  using System.Text;
//  using System.Threading.Tasks;
//  //using global::AnySerializer;
//  using P9Control.Api.Features.AnySerializer.NftDataTypes.PurchaseOrder;

//  public class NftTypeSerializer
//  {

//    private object DeserializeData(uint nft, string aDataString)
//    {
//      if (nft == 1)
//      {
//        byte[] serializedImmutableData = Convert.FromBase64String(aDataString);

//        PurchaseOrderData aDeserializedObject = Serializer.Deserialize<PurchaseOrderData>(serializedImmutableData, 0); // options == 0


//       return aDeserializedObject;

       
//      }
//      else
//      {
//        return aDataString;
//        //aOwnedToken.Data = aDataString;

//        //TokenDataList.Add(aOwnedToken);
//      }
//    }
//  }
//}
