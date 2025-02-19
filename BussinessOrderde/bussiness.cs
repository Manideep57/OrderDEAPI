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
            List<OrderDetailsModel> lstOrderde = new List<OrderDetailsModel>();
            lstOrderde=obj.GetOrderDetails();
            return lstOrderde;

        }

    }
}
