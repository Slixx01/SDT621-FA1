using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionB_Q1_EmfuleniMunicipality
{
    public class Resident
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int AccountNumber { get; set; }
        public double MonthlyUtilityUsage { get; set; }

        public Resident(string name, string address, int accountNumber, double monthlyUsage) 
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUtilityUsage = monthlyUsage;

        }
    }
}
