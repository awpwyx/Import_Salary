using Cstool;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Select
    {
        private readonly string connstr = CsDbHelperSql.ConnStr("AppConnStr");
        public DataSet From2_select(int id,string label)
        {

            SqlParameter[] parameter = {
                new SqlParameter("@Id",id),
                new SqlParameter("@label", label),


                                       };
            return CsDbHelperSql.RunProcedureDataSet("project_select", parameter, connstr);



        }
    }
}