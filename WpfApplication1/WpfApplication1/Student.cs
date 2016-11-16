using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Student:Person
    {
        private FreeOrContract freeOrContract;

        public Student():base()
        {
            freeOrContract = FreeOrContract.Free;           
        }
        public Student(Person p,FreeOrContract fc) : base(p.Name, p.LastName, p.Surname, p.PassportInfo)
        {
            freeOrContract = fc;
        }
        public FreeOrContract FreeOrContract
        {
            get
            {
                return freeOrContract;
            }

            set
            {
                freeOrContract = value;
            }
        }
        public override bool Equals(object obj)
        {
            return base.PassportInfo.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
