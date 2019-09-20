using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public addContact(string name, string id, string phone)
        {
            Contact contact = new Contact(name, id, phone);
            if (!this.persons.Contains(contact))
            {
                this.persons.Add(contact);
            }
        }

        public removeContact(Contact contact)
        {
            if (this.persons.Contains(contact))
            {
                this.persons.Remove(contact);
            }
        }
    }
}