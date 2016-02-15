using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input first number:");
            string A = Console.ReadLine();

            Console.Write("(+,-,*,/): ");
            string B = Console.ReadLine();

            Console.WriteLine("input second number:");

            string C = Console.ReadLine();

            string D = "";

            if (B == "+")
                D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            if (B == "-")
                D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            if (B == "*")
                D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            if (B == "/")
                D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));

            Console.WriteLine("result: " + D);
        }
    }

    class ProgramV2
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("input first number:");
                string strNumberA = Console.ReadLine();

                Console.Write("(+,-,*,/): ");
                string strOperate = Console.ReadLine();

                Console.WriteLine("input second number:");
                string strNumberB = Console.ReadLine();

                string strResult = "";

                switch (strOperate)
                { 
                    case "+":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (strNumberB != "0")
                            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        else
                            strResult = "Divisor can't be 0";
                        break;
                }
                Console.WriteLine("result: " + strResult);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error input:" + ex.ToString());
            }
        }
    }

    public class User
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;
                    break;
            }

            return result;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("input first number:");
                string strNumberA = Console.ReadLine();

                Console.Write("(+,-,*,/): ");
                string strOperate = Console.ReadLine();

                Console.WriteLine("input second number:");
                string strNumberB = Console.ReadLine();

                string strResult = "";
                
                strResult = Convert.ToString(User.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));

                Console.WriteLine("result: " + strResult);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error input:" + ex.ToString());
            }
        }
    }

    public class UserBase
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    class UserAdd : UserBase
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    class UserSub : UserBase
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    class UserMul : UserBase
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    class UserDiv : UserBase
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("Divisor can't be 0");
            
            result = NumberA / NumberB;
            
            return result;
        }
    }

    public class UserFactory
    {
        public static UserBase CreateOperate(string operate)
        {
            UserBase oper = null;
            switch (operate)
            {
                case "+":
                    oper = new UserAdd();
                    break;
                case "-":
                    oper = new UserSub();
                    break;
                case "*":
                    oper = new UserMul();
                    break;
                case "/":
                    oper = new UserDiv();
                    break;
            }

            return oper;
        }

        static void main(string[] args)
        {
            UserBase oper;
            oper = UserFactory.CreateOperate("+");
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
        }
    }

    public class FactoryMethod
    {
        
        interface IFactory
        {
            UserBase CreateUser();
        }

        class AddFactory : IFactory
        {
            public UserBase CreateUser()
            {
                return new UserAdd();
            }
        }

        class SubFactory : IFactory
        {
            public UserBase CreateUser()
            {
                return new UserSub();
            }
        }

        class MulFactory : IFactory
        {
            public UserBase CreateUser()
            {
                return new UserMul();
            }
        }

        class DivFactory : IFactory
        {
            public UserBase CreateUser()
            {
                return new UserDiv();
            }
        }

        static void main(string[] args)
        {
            IFactory operFactory = new AddFactory();
            UserBase oper = operFactory.CreateUser();
            oper.NumberA = 1;
            oper.NumberB = 2;
            double result = oper.GetResult();
        }
    }
}
