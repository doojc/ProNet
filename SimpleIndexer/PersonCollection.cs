using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople =
            new Dictionary<string, Person>();

        // This indexer returns a person based on a string index.
        public Person this[string name]
        {
            get { return (Person)listPeople[name]; }
            set { listPeople[name] = value; }
        }

        public void ClearPeople()
        { listPeople.Clear(); }

        public int Count
        {
            get { return listPeople.Count; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        { return listPeople.GetEnumerator(); }

        //private ArrayList arPeople = new ArrayList();

        //// Custom indexer for this class.
        //public Person this[int index]
        //{
        //    get { return (Person)arPeople[index]; }
        //    set { arPeople.Insert(index, value); }
        //}

        //// Cast for caller.
        //public Person GetPerson(int pos)
        //{ return (Person)arPeople[pos]; }

        //// Only insert Person objects.
        //public void AddPerson(Person p)
        //{ arPeople.Add(p); }

        //public void ClearPeople()
        //{ arPeople.Clear(); }

        //public int Count
        //{ get { return arPeople.Count; } }

        //// Foreach enumeration support.
        //IEnumerator IEnumerable.GetEnumerator()
        //{ return arPeople.GetEnumerator(); }
    }
}
