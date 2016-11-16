using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Cathedra
    {
        private HashSet<Group> groups;
      private  HashSet<Employee> staff;
        private Employee cathedraHeader;

        internal HashSet<Group> Groups
        {
            get
            {
                return groups;
            }

            set
            {
                groups = value;
            }
        }

        internal HashSet<Employee> Staff
        {
            get
            {
                return staff;
            }

            set
            {
                staff = value;
            }
        }

        internal Employee CathedraHeader
        {
            get
            {
                return cathedraHeader;
            }

            set
            {
                cathedraHeader = value;
            }
        }

        public bool AddNewEmployee(Employee employee)
        {
            return staff.Add(employee);
        }
        public bool AddNewGroup(Group group)
        {
            return groups.Add(group);
        }

        public List<Employee> GetEmployee(Person p)
        {
            List<Employee> foundStudents = new List<Employee>();
            foreach (var v in staff)
            {
                if (p.Equals(v))
                    foundStudents.Add(v);
            }
            return foundStudents;
        }

        public Group GetGroup(string name)
        {
            Group group = new Group(name);
            foreach (var g in groups)
                if (g.Equals(group)) return g;
            return  null;
        }

        public bool RemoveEmployee(Employee employee)
        {
            return staff.Remove(employee);
        }

        public bool RemoveGroup(Group group)
        {
            return groups.Remove(group);
        }
    }
}
