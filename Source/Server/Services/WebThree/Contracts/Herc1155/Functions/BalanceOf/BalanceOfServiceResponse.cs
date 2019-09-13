namespace P9Control.Server.Services.WebThree.Contracts.Herc1155.BalanceOf
{ 
  using P9Control.Api.Features.Base;
  using P9Control.Api.Features.WebThree;
  using System.Collections.Generic;
    using System.Numerics;

    public class BalanceOfServiceResponse : BaseResponse
    {
    public int Balance { get; set; }
    }
}
