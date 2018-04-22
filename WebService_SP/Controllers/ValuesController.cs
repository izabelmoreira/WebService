using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;


namespace WebService_SP.Controllers
{
    public class ValuesController : ApiController
    {
        database_Access_Layer.db dblayer = new database_Access_Layer.db();

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public DataSet GetRecord(int id)
        {
            DataSet ds = dblayer.GetRecordById(id);
                return ds;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        public DataSet VDSaldo(int id_cartao, int id_onibus, [FromBody]string value)
        {


            DataSet VDSaldo = dblayer.VDSaldo(id_cartao, id_onibus);
            return VDSaldo;
        }
            // PUT api/values/5
            public void Put(int id,[FromBody]string value)
        {
          
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
