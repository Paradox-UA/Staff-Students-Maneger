using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    //made
    class Passport
    {
        private string Id;
        private int number;

        public Passport(string id,int number)
        {
            this.Id = id;
            this.number = number;
        }
        public  Passport()
        {
            Id = "ID";
            number = 0;
        }
        public string ID
        {
            get
            {
                return Id;
            }

            set
            {
                Id = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }
    }
}
