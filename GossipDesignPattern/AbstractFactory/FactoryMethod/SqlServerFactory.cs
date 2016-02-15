using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory.FactoryMethod
{
    class SqlServerFactory : IFactory
    {
        public IUserOperation CreateUserOperation()
        {
            return new SqlServerUser();
        }

        public IDepartmentOperation CreateDepartmentOperation()
        {
            return new SqlServerDepartment();
        }
    }
}
