using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory.FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            var dept = new Department();

            IFactory factory = new SqlServerFactory();

            IUserOperation iOper = factory.CreateUserOperation();

            iOper.Insert(user);
            iOper.GetUser(1);

            factory = new AccessFactory();

            IDepartmentOperation id = factory.CreateDepartmentOperation();
            id.Insert(dept);
            id.GetDepartment(1);

            Console.Read();
        }
    }
}
