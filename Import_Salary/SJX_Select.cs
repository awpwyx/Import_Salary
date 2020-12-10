using Cstool;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import_Salary
{
     public class SJX_Select
    {
        private readonly string connstr = CsDbHelperSql.ConnStr("AppConnStr");

        public DataSet Client_Select_Contract(int beginyear,int endmonth)
        {

            SqlParameter[] parameter = {

                 new SqlParameter("@beginyear",beginyear),
                 new SqlParameter("@endmonth",endmonth),
                 

                                       };

            return CsDbHelperSql.RunProcedureDataSet("sp_HS_WYX_Client_Select_Organization", parameter, connstr);
        }
    }
}
//<supportedRuntime version = "v4.0" sku=".NETFramework,Version=v4.0"/>