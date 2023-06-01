using CourseProjectCSharp.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectCSharp.Classes
{
    public class Abonent : Person, ICloneable
    {
        private Date waitingTime;

        public Date WaitingTime
        {
            get { return waitingTime; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Waiting time date value must not be null.");
                if (value > this.Birthdate)
                    throw new ArgumentException("Birthdate cannot be later than waiting time");
                waitingTime = value;
            }
        }

        public Abonent() : base()
        {
            WaitingTime = new Date(25, 1, 2020);
        }

        public Abonent(Date birthdate, string firstname, string lastname, string occupation, Gender gender, int salary, Date waitingTime) 
            : base(birthdate, firstname, lastname, occupation, gender, salary)
        {
            WaitingTime = waitingTime;
        }
        public Abonent(Abonent other)
        {
            Birthdate = (Date)other.Birthdate.Clone();
            Firstname = other.Firstname;
            Lastname = other.Lastname;
            Occupation = other.Occupation;
            Gender = other.Gender;
            Salary = other.Salary;
            WaitingTime = (Date)other.WaitingTime.Clone();
        }

        public override string ToString()
        {
            return "Person{ " + $"Birthdate: {Birthdate}, Firstname: {Firstname} Lastname: {Lastname} " +
                   $"Occupation: {Occupation}, Gender: {Gender}, Salary: {Salary}, Waiting Time: {WaitingTime}" + "}";
        }

        public object Clone()
        {
            return new Abonent(this);
        }
    }
}
