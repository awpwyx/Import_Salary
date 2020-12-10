using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJX_Model
{
    public class M_JX_Budget
    {
        private static int _iD;//           
        public int ID
        {
            set { _iD = value; }
            get { return _iD; }
        }

        private static string _fBillNo;//           
        public string FBillNo
        {
            set { _fBillNo = value; }
            get { return _fBillNo; }
        }

        private static string _fProjectNumber;//           
        public string FProjectNumber
        {
            set { _fProjectNumber = value; }
            get { return _fProjectNumber; }
        }

        private static decimal _fSumPrice;//           
        public decimal FSumPrice
        {
            set { _fSumPrice = value; }
            get { return _fSumPrice; }
        }

        private static string _fDepartment;//           
        public string FDepartment
        {
            set { _fDepartment = value; }
            get { return _fDepartment; }
        }
        private static string _fSourceFunds;//           
        public string FSourceFunds
        {
            set { _fSourceFunds = value; }
            get { return _fSourceFunds; }      
        }

        private static string _fCreateTime;// 
        public string FCreateTime
        {
            set { _fCreateTime = value; }
            get { return _fCreateTime; }
        }
        private static DateTime _fInsertTime;// 
        public DateTime FInsertTime
        {
            set { _fInsertTime = value; }
            get { return _fInsertTime; }
        }
    }
}
