using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectCSharp.classes
{
    public class Person : Date, ICloneable
    {
        private string firstname;
        private string lastname;
        private string occupation;
        private bool sex;
        private int salary;

        public string Firstname 
        {
            get { return firstname; }
            set 
            {
                if (value == null || value.Trim().Equals(""))
                    throw new ArgumentException("Firstname must not be empty");
                firstname = value; 
            }
        }

        public string Lastname
        { 
            get { return lastname; } 
            set
            {
                if (value == null || value.Trim().Equals(""))
                    throw new ArgumentException("Lastname must not be empty");
                lastname = value;
            } 
        }

        public string Occupation
        {
            get { return occupation; }
            set
            {
                if (value == null || value.Trim().Equals(""))
                    throw new ArgumentException("Occupation value must not be empty");
                occupation = value;
            }
        }

        public bool Sex 
        { 
            get { return sex; }
            set { sex = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Person(Date birthdate, string firstname, string lastname, string occupation, bool sex, int salary)
        {
            Year = birthdate.Year;
            Month = birthdate.Month;
            Day = birthdate.Day;

            Firstname = firstname;
            Lastname = lastname;
            Occupation = occupation;
            Sex = sex;
            Salary = salary;
        }

        public Person() : this(new Date(15, 1, 1990), "John", "Doe", "driver", true, 20000)
        { }

        public Person(Person other)
        {
            Year = other.Year;
            Month = other.Month;
            Year = other.Day;

            Firstname = other.Firstname;
            Lastname = other.Lastname;
            Occupation = other.Occupation;
            Sex = other.Sex;
            Salary = other.Salary;
        }
    }
}
