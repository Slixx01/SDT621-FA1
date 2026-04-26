

using System.Net.Cache;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SectionB_Q2_HomeAffairsIdentityProcessor
{
    public class CitizenProfile
    {
        public string Name { get; set; }
        public string IdNumber { get; set; }
        public int Age { get; private set; }


        public CitizenProfile(string name, string idNumber)
        {
            Name = name;
            IdNumber = idNumber;
            CalculateAge();
        }


        public void CalculateAge()
        {
            string Year = IdNumber.Substring(0, 2);
            int currentYear = DateTime.Now.Year % 100;
            int fullyear; 

            if(int.Parse(Year) > currentYear)
            {
                fullyear = int.Parse(Year) + 1900;     
            }
            else
            {
                fullyear = int.Parse(Year) + 2000;
            }

            Age = DateTime.Now.Year - fullyear; 
        }

        public string ValidateID()
        {
            if (IdNumber.Length == 13 && IdNumber.All(char.IsDigit))
            {
                return $"Valid ID. Citizen is {Age} years old";                     
            }
            else
            {
                return $"ID is not valid"; 
            }
        }
    }
}