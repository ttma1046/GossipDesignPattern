using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory.FactoryMethod
{
    interface IDepartmentOperation
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}
