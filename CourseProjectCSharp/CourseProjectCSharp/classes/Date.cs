using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectCSharp.classes
{
    public class Date : ICloneable
    {
        private readonly static Dictionary<int, int> monthDaysDictionary;

        private int day;
        private int month;
        private int year;

        static Date()
        {
            monthDaysDictionary = new Dictionary<int, int>();
            monthDaysDictionary[1] = 31;  //JANUARY
            monthDaysDictionary[2] = 28;  //FEBRUARY
            monthDaysDictionary[3] = 31;  //MARCH
            monthDaysDictionary[4] = 30;  //APRIL
            monthDaysDictionary[5] = 31;  //MAY
            monthDaysDictionary[6] = 30;  //JUNE
            monthDaysDictionary[7] = 31;  //JULY
            monthDaysDictionary[8] = 31;  //AUGUST
            monthDaysDictionary[9] = 30;  //SEPTEMBER
            monthDaysDictionary[10] = 31; //OCTOBER
            monthDaysDictionary[11] = 30; //NOVEMBER
            monthDaysDictionary[12] = 31; //DECEMBER
        }
        public int Day
        {
            get { return day;}
            set
            {
                if (value < 1 || value > monthDaysDictionary[Month]) 
                    throw new ArgumentOutOfRangeException("Incorrect day value");
                day = value; 
            } 
        }

        public int Month
        {
            get { return month; }
            set 
            { 
                if (value < 1 || value > 12 )
                    throw new ArgumentOutOfRangeException("Incorrect month value!");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set 
            { 
                if (value < 1900 || value > 2100)
                    throw new ArgumentOutOfRangeException("Incorrect year value!");                
                year = value; 
            }
        }

        public Date()
        {
            Year = 1900;
            Month = 1;
            Day = 1;
        }

        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;
        }

        public Date(Date other)
        {
            Year = other.Year;
            Month = other.Month;
            Day = other.Day;
        }

        ~Date() { }
        
        //if you overload a binary operator, such as +, += is also overloaded.
        public static Date operator +(Date date, int days)
        {
            if (days < 0)
                return date - (-days);
            else if (date.Day + days <= monthDaysDictionary[date.Month])
            {
                date.Day += days;
                return date;
            }

            int prevMonthDays = monthDaysDictionary[date.Month];
            if (date.month < 12)
               date.month++;
            else
            {
               date.month = 1;
               date.Year++;
            }
            int remainder = prevMonthDays - date.day;
            date.day = 1;

            return date += days + remainder - 1;
        }

        public static Date operator -(Date date, int days)
        {
            if (days < 0)
                return date + (-days);
            else if (date.Day - days >= 1)
            {
                date.Day -= days;
                return date;
            }

            int prevMonthDays = monthDaysDictionary[date.Month];
            if (date.month > 1)
                date.month--;
            else
            {
                date.month = 12;
                date.Year--;
            }
            int remainder = days - date.day;
            date.day = monthDaysDictionary[date.Month];

            return date -= remainder;
        }

        //public static Date operator =(Date date1) => new(date1);

        public object Clone()
        {
            return new Date(this);
        }

    }

}
