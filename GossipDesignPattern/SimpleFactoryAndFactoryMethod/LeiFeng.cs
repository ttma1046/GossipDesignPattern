using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GossipDesignPattern.SimpleFactory
{
    // 简单工厂模式的最大优点在于工厂类中包含了必要的逻辑判断, 根据客户端的选择条件动态实例化相关的类，对于客户端来说，去除了与具体产品的依赖。
    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("Sweep!");
        }

        public void Wash()
        {
            Console.WriteLine("Wash!");
        }

        public void BuyRice()
        {
            Console.WriteLine("Buy Rice!");
        }
    }

    class Undergraduate: LeiFeng
    { 
        public void IamUndergraduate()
        {
            Console.WriteLine("I am undergraduate!");
        }
    }

    class ProgramV3
    {
        static void main(string [] args)
        {
            LeiFeng xueleifeng = new Undergraduate();

            xueleifeng.BuyRice();
            xueleifeng.Sweep();
            xueleifeng.Wash();

            LeiFeng student1 = new Undergraduate();
            student1.BuyRice();

            LeiFeng student2 = new Undergraduate();
            student1.Sweep();

            LeiFeng student3 = new Undergraduate();
            student1.Wash();
        }
    }

    class Volunteer : LeiFeng
    {
    }

    class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng result = null;
            switch (type)
            {
                case "Undergraduate":
                    result = new Undergraduate();
                    break;
                case "Volunteer":
                    result = new Volunteer();
                    break;
            }

            return result;
        }

        static void main(string[] args)
        {
            LeiFeng studentA = SimpleFactory.CreateLeiFeng("Undergraduate");

            studentA.BuyRice();

            LeiFeng studentB = SimpleFactory.CreateLeiFeng("Undergraduate");

            studentB.Sweep();

            LeiFeng studentC = SimpleFactory.CreateLeiFeng("Undergraduate");

            studentC.Wash();
        }
    }

    //工厂方法克服了简单工厂违背开放-封闭原则的缺点，又保持了封装对象创建过程的优点
    //工厂方法模式是定义一个用于创建对象的接口，让子类决定实例化哪一个类。
    class FactoryMethodForLeiFeng
    {
        interface ILeiFengFactory
        {
            LeiFeng CreateLeiFeng();
        }

        class UndergraduateFactory : ILeiFengFactory
        {
            public LeiFeng CreateLeiFeng()
            {
                return new Undergraduate();
            }
        }

        class VolunteerFactory : ILeiFengFactory
        {
            public LeiFeng CreateLeiFeng()
            {
                return new Volunteer();
            }
        }

        static void main(string[] args)
        {
            ILeiFengFactory factory = new UndergraduateFactory();

            LeiFeng student = factory.CreateLeiFeng();

            student.BuyRice();
            student.Sweep();
            student.Wash();
        }
    }
}
