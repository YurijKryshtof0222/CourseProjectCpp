using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectCSharp.classes
{
    public class BuildingsQueue : List<Person>
    {
        public void SortByDecrasingWaitingTime()
        {
            this.Sort((Person x, Person y) =>
            {
                return -(x.WaitingTime.CompareTo(y.WaitingTime));
            });
        }

    }

}
