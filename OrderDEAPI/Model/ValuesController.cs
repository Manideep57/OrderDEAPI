using DBlayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace OrderDEAPI.Model
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("GetOrderDetails")]
        public List<OrderDetailsModel> GetOrderDetails()
        {
            List<OrderDetailsModel> lstOrderde=new List<OrderDetailsModel>();
            OrderdeDB obj = new OrderdeDB();
            lstOrderde=obj.GetOrderDetails();
          return lstOrderde;

        }
    }
}
