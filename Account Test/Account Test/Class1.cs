using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Test
{
    class SavingsAccount
    {
        //fields
        private string _accountNumber;
        private decimal _interestRate;
        private decimal _balance;

        //constructor
        public SavingsAccount()
        {
            _accountNumber = "";
            _interestRate = 0;
            _balance = 0;
        }

        //accountnumber property
        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        //interestrate property
        public decimal InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        //balance property
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

    }
    class CDAccount : SavingsAccount
    {
        //field
        private string _maturityDate;
        //constructor
        public CDAccount()
        {
            _maturityDate = "";
        }
        //maturity date property
        public string MaturityDate
        {
            get { return _maturityDate; }
            set { _maturityDate = value; }
        }
    }
}
