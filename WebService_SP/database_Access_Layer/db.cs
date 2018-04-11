using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace WebService_SP.database_Access_Layer
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public DataSet GetRecordById(int id)
        {
            SqlCommand com = new SqlCommand("SpGetDetailById", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ID_CARTAO", id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
    }
}