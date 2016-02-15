using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory.FactoryMethod
{
    class AccessFactory : IFactory
    {
        public IUserOperation CreateUserOperation()
        {
            return new AccessUser();
        }

        public IDepartmentOperation CreateDepartmentOperation()
        {
            return new AccessDepartment();
        }
    }
}
