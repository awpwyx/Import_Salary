using System;

namespace SJX.Model
{
    public class M_JX_Budget_Entry
    {
        private static int _iD;//           
        public int ID
        {
            set { _iD = value; }
            get { return _iD; }
        }

        private static string _fInterId;//           
        public string FInterId
        {
            set { _fInterId = value; }
            get { return _fInterId; }
        }

        private static string _fBudgetCode;//           
        public string FBudgetCode
        {
            set { _fBudgetCode = value; }
            get { return _fBudgetCode; }
        }

        private static string _fPrice;//           
        public string FPrice
        {
            set { _fPrice = value; }
            get { return _fPrice; }
        }

    }
}
