using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectCSharp.classes
{
    public class Person : IDate, ICloneable
    {
        private Date birthdate;
        private string firstname;
        private string lastname;
        private string occupation;
        private bool sex;
        private int salary;
        private Date waitingTime;

        public Date Birthdate
        {
            get { return birthdate; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Bithdate value must not be null.");
                birthdate = value;
            }
        }

        public string Firstname 
        {
            get { return firstname; }
            set 
            {
                if (value == null || value.Trim().Equals(""))
                    throw new ArgumentNullException("Firstname must not be empty.");
                firstname = value; 
            }
        }

        public string Lastname
        { 
            get { return lastname; } 
            set
            {
                if (value == null || value.Trim().Equals(""))
                    throw new ArgumentNullException("Lastname must not be empty.");
                lastname = value;
            } 
        }

        public string Occupation
        {
            get { return occupation; }
            set
            {
                if (value == null || value.Trim().Equals(""))
                    throw new ArgumentNullException("Occupation value must not be empty.");
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
            set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Salary value must not be less than 0.");
                salary = value; 
            }
        }

        public Date WaitingTime
        {
            get { return waitingTime; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Waiting time date value must not be null.");
                waitingTime = value;
            }
        }

        public Person(Date birthdate, string firstname, string lastname, string occupation, bool sex, int salary, Date waitingTime)
        {
            Birthdate = birthdate;
            Firstname = firstname;
            Lastname = lastname;
            Occupation = occupation;
            Sex = sex;
            Salary = salary;
            WaitingTime = waitingTime;
        }

        public Person() : this(new Date(15, 1, 1990), "John", "Doe", "driver", true, 20000, new Date(25, 1, 2010))
        { }

        public Person(Person other)
        {
            Birthdate = other.Birthdate;
            Firstname = other.Firstname;
            Lastname = other.Lastname;
            Occupation = other.Occupation;
            Sex = other.Sex;
            Salary = other.Salary;
            WaitingTime = other.WaitingTime;
        }

        ~Person()
        { }

        public string DateToString()
        {
            return string.Format("{0}_{1}{2}_{3}", Birthdate.Year, Birthdate.Month < 10 ? "0" : "", Birthdate.Month, Birthdate.Day);
        }

        public object Clone()
        {
            return new Person(this);
        }

    }

}
