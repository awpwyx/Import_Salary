using System;

namespace SJX.Model
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

        private static string _fProjectCode;//           
        public string FProjectCode
        {
            set { _fProjectCode = value; }
            get { return _fProjectCode; }
        }

        private static string _fSumPrice;//           
        public string FSumPrice
        {
            set { _fSumPrice = value; }
            get { return _fSumPrice; }
        }

    }
}
