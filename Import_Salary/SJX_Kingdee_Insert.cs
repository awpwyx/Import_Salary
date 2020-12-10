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
     public class SJX_Kingdee_Insert
    {
        private readonly string connstr = CsDbHelperSql.ConnStr("KingdeeCloud");

        public DataSet Client_Insert_Budget(M_JX_Budget model)// 
        { 
            SqlParameter[] parameter = {

                new SqlParameter("@ID", model.ID),
                    new SqlParameter("@FBillNo", model.FBillNo),
                        new SqlParameter("@FProjectNumber", model.FProjectNumber),
                            new SqlParameter("@FSumPrice", model.FSumPrice),
                            new SqlParameter("@FSourceFunds", model.FSourceFunds),
                            new SqlParameter("@FDepartment", model.FDepartment),
                            new SqlParameter("@FCreateTime", model.FCreateTime),
                            new SqlParameter("@FInsertTime", model.FInsertTime)
                                       };

            return CsDbHelperSql.RunProcedureDataSet("sp_HS_JX_Client_Insert_Budget", parameter, connstr);
        }
        public DataSet Client_Insert_BudgetEntry(M_JX_Budget_Entry model) // 
        { 
            SqlParameter[] parameter = {

                new SqlParameter("@FInterId", model.FInterId),
                    new SqlParameter("@FBudgetNumber", model.FBudgetNumber),
                        new SqlParameter("@FPrice", model.FPrice),
                                       };

            return CsDbHelperSql.RunProcedureDataSet("sp_HS_JX_Client_Insert_BudgetEntry", parameter, connstr);
        }
    }
}
//<supportedRuntime version = "v4.0" sku=".NETFramework,Version=v4.0"/>