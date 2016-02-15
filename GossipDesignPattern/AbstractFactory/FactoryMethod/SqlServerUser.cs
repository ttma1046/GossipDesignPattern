using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory.FactoryMethod
{
    class SqlServerUser : IUserOperation
    {
        public void Insert(User user)
        {
            Console.WriteLine("Insert user into user table of Sql Server.");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("Retrive a record from User table of Sql Server.");
            return null;
        }
    }
}
