using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory.FactoryMethod
{
    class AccessDepartment : IDepartmentOperation
    {
        public void Insert(Department department)
        {
            Console.WriteLine("Insert department into department table of Sql Server.");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("Retrive a record from department table of Sql Server.");
            return null;
        }
    }
}
