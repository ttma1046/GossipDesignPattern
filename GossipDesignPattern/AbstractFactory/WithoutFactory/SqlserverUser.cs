using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.AbstractFactory
{
    class SqlServerUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Insert user into user table of sql server");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("Retrive a record from User table of sql server");
            return null;
        }
    }
}
