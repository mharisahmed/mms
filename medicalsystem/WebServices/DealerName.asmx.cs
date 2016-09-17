using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Serialization;

namespace medicalsystem.WebServices
{
    /// <summary>
    /// Summary description for DealerName
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. Zindagi Kitni Haseen Hay Nightcrawler
    [System.Web.Script.Services.ScriptService]
    public class DealerName : System.Web.Services.WebService
    {

        [WebMethod]
        public void DealerNameExists(string DealerName)
        {
            bool DealerNameInUse = false;

            string cs = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("usp_DealerNameExists", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@DealerName",
                    Value = DealerName
                });

                con.Open();
                DealerNameInUse = Convert.ToBoolean(cmd.ExecuteScalar());
            }

            Registration regsitration = new Registration();
            regsitration.DealerName = DealerName;
            regsitration.DealerNameInUse = DealerNameInUse;

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(regsitration));
        }
    }
}
