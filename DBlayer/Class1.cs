using Microsoft.Data.SqlClient;
using Model;
namespace DBlayer
{
    public class OrderdeDB
    {
        public List<OrderDetailsModel>GetOrderDetails()
        {
            List<OrderDetailsModel>lstOrderde = new List<OrderDetailsModel>();
            SqlConnection obj1 = new SqlConnection();
            string strconnection = "Data Source=PC;Initial Catalog=mani;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            obj1.ConnectionString = strconnection;
            obj1.Open();
            string strcommand = "select * from Orderdetails";
            SqlCommand cmd =new SqlCommand(strcommand,obj1);
            cmd.CommandType=System.Data.CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    OrderDetailsModel model = new OrderDetailsModel();
                    model.OrderdeID = Convert.ToInt32(reader["OrderdetailsID"]);
                    model.OrderID = Convert.ToInt32(reader["OrderID"]);
                    model.ProductID = Convert.ToInt32(reader["ProductID"]);
                    model.Quantity = Convert.ToString(reader["Quantity"]);
                    lstOrderde.Add(model);

                }
            }
            return lstOrderde;




        }


    }
}
