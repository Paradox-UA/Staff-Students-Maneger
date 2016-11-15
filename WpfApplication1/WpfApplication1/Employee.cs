using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Employee:Person
    {
        private Position position;
        public Employee():base()
        {
            position = Position.SimpleCollaborator;
        }
        public Employee(Person p, Position ps) : base(p.Name, p.LastName, p.Surname, p.PassportInfo)
        {
            position = ps;
        }
        internal Position Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }
    }
}
