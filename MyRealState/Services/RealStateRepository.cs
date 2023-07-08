using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyRealState
{
    class RealStateRepository : IRealStateRepository
    {
        private string StringConnection = "Data Source=.;Initial Catalog=Contact_DB;Integrated Security=true";
        public bool Delete(int contactid)
        {
            SqlConnection connection = new SqlConnection(StringConnection);
            try
            {
                string Query = "Delete from MyRealState where ContactID=@contactid";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@contactid", contactid);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Edit(int contactid, string nameorfamily, string phonenumber, string saleOrrent, int meterage, int price, string address, string description)
        {
            SqlConnection connection = new SqlConnection(StringConnection);
            try
            {
                string Query = "update  MyRealState set NameOrFamily=@nameorfamily,PhoneNumber=@phonenumber,SaleOrRent=@saleorrent,Meterage=@meterage,Price=@price,Address=@address,Description=@description where  ContactID=@contactid ";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@nameorfamily", nameorfamily);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@saleorrent", saleOrrent);
                command.Parameters.AddWithValue("@meterage", meterage);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@contactID", contactid);
                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string nameorfamily, string phonenumber, string saleOrrent, int meterage, int price, string address, string description)
        {
            SqlConnection connection = new SqlConnection(StringConnection);
            try
            {
                string Query = "insert  into MyRealState (NameOrFamily,PhoneNumber,SaleOrRent,Meterage,Price,Address,Description) values (@nameorfamily,@phonenumber,@saleorrent,@meterage,@price,@address,@description)";
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@nameorfamily", nameorfamily);
                command.Parameters.AddWithValue("@phonenumber", phonenumber);
                command.Parameters.AddWithValue("@saleorrent", saleOrrent);
                command.Parameters.AddWithValue("@meterage", meterage);
                command.Parameters.AddWithValue("@price", price);
                command.Parameters.AddWithValue("@address", address);
                command.Parameters.AddWithValue("@description", description);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            string Query = "select * from MyRealState";
            SqlConnection connection = new SqlConnection(StringConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }

        public DataTable SelectRow(int contactid)
        {
            string Query = "select * from MyRealState where ContactID=" + contactid;
            SqlConnection connection = new SqlConnection(StringConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable searche(string parameter)
        {
            string Query = "select * from MyRealState where NameOrFamily like @parameter or saleorrent like @parameter ";
            SqlConnection connection = new SqlConnection(StringConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;

        }
    }
}
