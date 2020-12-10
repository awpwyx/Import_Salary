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
     public class SJX_Kingdee_Select
    {
        private readonly string connstr = CsDbHelperSql.ConnStr("KingdeeCloud");

        public DataSet Client_Select_by_Kingdee(string label1,string label2,int type) // 0---工程项目 1---预算科目
        {

            SqlParameter[] parameter = {

                new SqlParameter("@label1", label1),
                    new SqlParameter("@label2", label2),
                        new SqlParameter("@type", type),
                                       };

            return CsDbHelperSql.RunProcedureDataSet("sp_HS_JX_Client_Select_by_Kingdee", parameter, connstr);
        }
        public DataSet Client_Select_Max( int type) // 0---工程项目 1---预算科目
        {

            SqlParameter[] parameter = {

               
                        new SqlParameter("@type", type),
                                       };

            return CsDbHelperSql.RunProcedureDataSet("sp_HS_JX_Client_Select_Max", parameter, connstr);
        }
    }
}
//<supportedRuntime version = "v4.0" sku=".NETFramework,Version=v4.0"/>