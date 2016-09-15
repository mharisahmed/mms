using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Script.Serialization;

namespace medicalsystem
{
    /// <summary>
    /// Summary description for RegistrationService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class RegistrationService : System.Web.Services.WebService
    {

        [WebMethod]
        public void UserNameExists(string userName)
        {
            bool userNameInUse = false;

            string cs = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("usp_CompanyNameExists", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@Companyname",
                    Value = userName
                });

                con.Open();
                userNameInUse = Convert.ToBoolean(cmd.ExecuteScalar());
            }

            Registration regsitration = new Registration();
            regsitration.UserName = userName;
            regsitration.UserNameInUse = userNameInUse;

            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Write(js.Serialize(regsitration));
        }
    }
}

