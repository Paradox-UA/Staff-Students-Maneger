using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Group
    {
        private string nameGroup;
        private HashSet<Student> students;
        public Group (string name)
        {
            nameGroup = name;
            students = new HashSet<Student>();
        }
        public Group (string name, HashSet<Student> st)
        {
            nameGroup = name;
            students = st;
        }
        public string NameGroup
        {
            get
            {
                return nameGroup;
            }

            set
            {
                nameGroup = value;
            }
        }

        public HashSet<Student> Students
        {
            get
            {
                return students;
            }

            set
            {
                students = value;
            }
        }

        public bool AddNewStudent(Student student)
        {
            return students.Add(student);
        }
        public bool RemoveStudent(Student student)
        {           
            return students.Remove(student);            
        }
        public List<Student> GetStudents(Person p)
        {
            List<Student> foundStudents = new List<Student>();
            foreach(var v in students)
            {
                if (p.Equals(v))
                    foundStudents.Add(v);
            }
            return foundStudents;
        }

        public override int GetHashCode()
        {
            return nameGroup.GetHashCode();
        }
    }
}
