using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Web;
using System.Text;
using Newtonsoft.Json.Linq;

namespace ChinessResturantAPIs.Controllers
{
    public class ValuesController : ApiController
    {

        SqlConnection con = new SqlConnection("server=DESKTOP-CM5T7LO; database=ChiDragonDb; Integrated security=true ");
        // GET api/values
        public string Get()
        {
            //return new string[] { "value1", "value2" };

            SqlDataAdapter da = new SqlDataAdapter("select m.desription ,om.qty, o.OrderType,o.Status ,o.OrderDate from Orders as o join OrderMenue as om on om.OrdeRreference = o.OrdeRreference join Menue m on m.ItenNo = om.ItenNo ORDER BY om.OrdeRreference ASC", con);
            DataTable dt = new DataTable();


            da.Fill(dt);
            string Product_Category = String.Empty;
            if (dt.Rows.Count > 0)
            {

                //Product_Category = dt.Rows[0]["Product_Category"].ToString();
                //string JSONString = string.Empty;
                string JSONString = JsonConvert.SerializeObject(dt, Formatting.Indented);
                string finaldata = JSONString.Replace("\r\n", "").Replace(@"""", "");
                //System.Diagnostics.Debug.Write(JsonConvert.SerializeObject(dt));
                //Console.Write(JsonConvert.SerializeObject(dt));

                //JObject o = JObject.Parse(JSONString);
                //Console.WriteLine(o.ToString());
                //string jason2 = o.ToString();
                return finaldata;


            }
            else
            {
                return "no data found ";

            }
        }

        // GET api/values/pending
        public string Get(string id)
        {
            SqlDataAdapter da = new SqlDataAdapter(" select o.OrdeRreference ,m.desription ,om.qty, o.OrderType,o.Status ,o.OrderDate from Orders as o join OrderMenue as om on om.OrdeRreference = o.OrdeRreference join Menue m on m.ItenNo = om.ItenNo where o.Status <> '" + id + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string JSONString = JsonConvert.SerializeObject(dt, Formatting.Indented);
                string finaldata = JSONString.Replace("\r\n", "").Replace(@"""", "");
                return finaldata;
               

            }
            else
            {
                return "no data found ";

            }
        }

        // POST api/values
        public string Post([FromBody]string value)
        {

            SqlCommand cmd = new SqlCommand("insert into Orders values ('" + value + "')", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
              return "record inserted" + value;

            }
            else
            {
             return "Try again ";

            }


        }

        // PUT api/values/5
        public string Put(string ordref, [FromBody]string status)
        {

            SqlCommand cmd = new SqlCommand("update Orders set Status = '" + status + "' where OrdeRreference = '" + ordref + "'", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                return "record updated" + status;

            }
            else
            {
                return "Try again ";

            }
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Orders where status = '" + id + "'", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                return "record deleted" + id;

            }
            else
            {
                return "Try again ";

            }
        }
    }
}
