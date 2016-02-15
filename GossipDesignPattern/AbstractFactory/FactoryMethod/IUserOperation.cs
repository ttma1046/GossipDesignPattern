using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory.FactoryMethod
{
    interface IUserOperation
    {
        void Insert(User user);

        User GetUser(int id);
    }
}
