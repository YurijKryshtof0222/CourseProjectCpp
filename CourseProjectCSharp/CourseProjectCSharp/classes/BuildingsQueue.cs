using System.Collections;
using System.Xml.Serialization;

namespace CourseProjectCSharp.classes
{
    public class BuildingsQueue : List<Person>, IEnumerable<Person>, IEnumerable
    {
        public void SortByDecrasingWaitingTime()
        {
            this.Sort((Person x, Person y) =>
            {
                return (y.WaitingTime.CompareTo(x.WaitingTime));
            });
        }

        public new IEnumerator<Person> GetEnumerator()
        {
            return new BuildingsQueueEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void WriteToXML(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BuildingsQueue));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, this);
            }
        }

        public BuildingsQueue ReadFromXML(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BuildingsQueue));
            using (StreamReader reader = new StreamReader(fileName))
            {
                return serializer.Deserialize(reader) as BuildingsQueue;
            }
        }

    }

    public class BuildingsQueueEnumerator : IEnumerator<Person> 
    {
        private BuildingsQueue queue;
        private int currentPosition = -1;
        
        public BuildingsQueueEnumerator(BuildingsQueue queue)
        {
            this.queue = queue;
        }

        public Person Current
        {
            get
            {
                if (currentPosition == -1 || currentPosition >= queue.Count)
                    throw new InvalidOperationException();
                return queue[currentPosition];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose()
        {
            queue.Clear();
        }

        public bool MoveNext()
        {
            if (currentPosition < queue.Count - 1)
            {
                currentPosition++;
                return true;
            }
            return false;
        }

        public bool MovePrevious()
        {
            if (currentPosition - 1 >= 0)
            {
                currentPosition--;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            currentPosition = -1;
        }
    }

}