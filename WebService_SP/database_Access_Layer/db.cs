using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Http;

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

       public DataSet VDSaldo(int id_cartao, int id_onibus)
        {
            SqlCommand com = new SqlCommand("spValidaSaldoDebita", con);
                     
            com.Parameters.AddWithValue("@IDCARTAOEXT", id_cartao);
            com.Parameters.AddWithValue("@IDONIBUS", id_onibus);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet VDSaldo = new DataSet();
            da.Fill(VDSaldo);
            return VDSaldo;
                  
        }


    }
}