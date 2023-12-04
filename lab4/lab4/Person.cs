using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.Zad2
{
    public abstract class Person
    {
        public string FirstName;
        public string Surname;
        public string Pesel;

        public void SetFirstName(string firstName)
        {
            FirstName = firstName;
        }
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetPesel(string pesel)
        {
            Pesel = pesel;
        }
        public int GetAge()
        {
            var year = int.Parse(Pesel.Substring(0,2));

            return (2023 - year);
        }

        public string GetGender()
        {
            return int.Parse(Pesel[9].ToString()) % 2 == 0 ? "Female" : "Male";
        }

        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();



    }
}
