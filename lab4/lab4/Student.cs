using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Zad2
{
    public class Student : Person
    {
        public string School { get; set; }
        public bool CanGoHomeAlone { get; set; }

        public void SetSchool(string school)
        {
            if (string.IsNullOrEmpty(School)) School = school;
            else throw new Exception("School is set");

            //School = school;
        }

        public void ChangeSchool(string school)
        {
            School = school;
        }

        public void SetCanGoHomeAlone(bool canGoHomeAlone)
        {
            CanGoHomeAlone = canGoHomeAlone;
        }

        public string Info()
        {
            return CanGoAloneToHome() ? "Może wracać sam" + (GetAge() < 12 ? "ma pozwolenie" : "") : "Nie może wracać sam";
        }

        /*public override bool CanGoHomeAlone()
        {
            return CanGoHomeAlone || GetAge() >= 12;
        }*/
        
        public override bool CanGoAloneToHome()
        {
            throw new NotImplementedException();
        }

        public override string GetEducationInfo()
        {
            throw new NotImplementedException();
        }

        public override string GetFullName()
        {
            throw new NotImplementedException();
        }

        internal bool CanGoHomeAlone()
        {
            throw new NotImplementedException();
        }
    }
}
