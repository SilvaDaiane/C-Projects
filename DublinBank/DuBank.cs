using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DublinBank
{
    internal class DuBank
    {
        //Constructor
        public DuBank () { }

        public DuBank(int accountNo, string name, string address, string phoneNo, decimal balance, string password) 
        {
            AccountNo = accountNo;
            Name = name;
            Address = address;
            PhoneNo = phoneNo;
            Balance = balance;
            Password = password;

        
        }
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public decimal Balance { get; set; }
        public string Password { get; set; }
    }
}
