using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    //made
    class Person
    {
        private string name;
        private string lastName;
        private string surname;
        private Passport passportInfo;

        public Person (string name1,string lastname,string surname1,Passport passport)
        {
            this.name = name1;
            this.lastName = lastname;
            this.surname = surname1;
            passportInfo = new Passport(passport.ID, passport.Number);
        }
        public Person ()
        {
            name = "Name";
            lastName = "Last Name";
            surname = "Surname";
            passportInfo = new Passport();
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        internal Passport PassportInfo
        {
            get
            {
                return passportInfo;
            }

            set
            {
                passportInfo = value;
            }
        }
        public override int GetHashCode()
        {
            return passportInfo.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Person p = obj as Person;
            if (p.Name == this.name && p.Surname == this.surname)
                return true;
            else return false;
        }
        public override string ToString()
        {
            return name + " " + lastName + " " + surname;
        }
    }
}
