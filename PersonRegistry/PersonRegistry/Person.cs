using System;

namespace PersonRegistry
{
    public abstract class Person : IComparable<Person>
    {
        protected string _firstName { get; set; }
        protected string _lastName { get; set; }

        public Person(string Firstname, string Lastname)
        {
            _firstName = Firstname;
            _lastName = Lastname;
        }

        public virtual string GetFirstName()
        {
            return _firstName;
        }

        public virtual string GetLastName()
        {
            return _lastName;
        }
        public static Person operator +(Person female, Person male)
        {
            return new Child("Child", female._firstName, male._lastName);
        }

        public abstract string GetPerson();
        
        /// <summary>
        /// Sorting method which is called in the sort button of Form1
        /// </summary>
        int IComparable<Person>.CompareTo(Person other)
        {
            if (this._lastName == other._lastName)
            {
                return this._firstName.CompareTo(other._firstName);
            }
            return this._lastName.CompareTo(other._lastName);
        }
    }
}