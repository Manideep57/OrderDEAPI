using DBlayer;
using Microsoft.Identity.Client;
using Model;
namespace BussinessOrderde
{
    public class bussiness
    {
        public List<OrderDetailsModel> GetOrderDetails()
        {
            OrderdeDB obj = new OrderdeDB();    
            List<OrderDetailsModel> lstOrderdes = new List<OrderDetailsModel>();
            lstOrderdes=obj.GetOrderDetails();
            return lstOrderdes;

        }

    }
}
