using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class TelephoneDictionary : IEnumerable
    {
        public List<Person> peopleData = new List<Person>(50);

        public TelephoneDictionary()
        {
            
        }

        public void AddPerson(Person person)
        {
            if (peopleData.Count <= 50)
            {
                peopleData.Add(person);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return peopleData.GetEnumerator();
        }
    }
}
