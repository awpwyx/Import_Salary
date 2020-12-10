using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJX_Model
{
    public class M_JX_Budget_Entry
    {
        private static int _iD;//           
        public int ID
        {
            set { _iD = value; }
            get { return _iD; }
        }

        private static int _fInterId;//           
        public int FInterId
        {
            set { _fInterId = value; }
            get { return _fInterId; }
        }

        private static string _fBudgetNumber;//           
        public string FBudgetNumber
        {
            set { _fBudgetNumber = value; }
            get { return _fBudgetNumber; }
        }

        private static decimal _fPrice;//           
        public decimal FPrice
        {
            set { _fPrice = value; }
            get { return _fPrice; }
        }
    }
}
