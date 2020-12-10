using Cstool;
using SJX_Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import_Salary
{
     public class SJX_Kingdee_Delete
    {
        private readonly string connstr = CsDbHelperSql.ConnStr("KingdeeCloud");

        public DataSet Client_Delete_Kingdee(int ID, int type)// 
        { 
            SqlParameter[] parameter = {

                new SqlParameter("@ID", ID),
                 new SqlParameter("@type", type),

                                       };

            return CsDbHelperSql.RunProcedureDataSet("sp_HS_JX_Client_Delete_Kingdee", parameter, connstr);
        }
      
    }
}
//<supportedRuntime version = "v4.0" sku=".NETFramework,Version=v4.0"/>