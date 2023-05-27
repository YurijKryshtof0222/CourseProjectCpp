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
        public class Enumarator : IEnumerator<Person>
        {
            public Person Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public void SortByDecrasingWaitingTime()
        {
            this.Sort((Person x, Person y) =>
            {
                return x.WaitingTime.CompareTo(y.WaitingTime);
            });
        }

    }

}
