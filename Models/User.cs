using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagmentSystem.Models
{
    public class User
    {
        public string UserId { get; set; }
        public long useraccount { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string guardiantype { get; set; }
        public string guardianname { get; set; }
        public string address { get; set; }
        public string citizenship { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string maritalstatus { get; set; }
        public long contactnumber { get; set; }
        public DateTime dateofbirth { get; set; }
        public DateTime registrationDate { get; set; }
        public string accounttype { get; set; }
        public string branchname { get; set; }
        public string citizenshipstatus { get; set; }
        public long initialdeposit { get; set; }

        public string idcardnumber { get; set; }
        public string referenceaccountholdername { get; set; }
        public long referenceaccountholderaccountnumber { get; set; }
        public string referenceaccountholderaddress { get; set; }
    }
}
