using factory.工厂模式设计模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public interface IHuman
    {
        void GetColor();
        void Talk();
    }
    [TypeNameToInstance("yellow")]
    public class YellowMan : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("Yellow");
        }

        public void Talk()
        {
            Console.WriteLine("Yellow Talk");
        }
    }
    public class WhiteMan : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("White");
        }

        public void Talk()
        {
            Console.WriteLine("White Talk");
        }
    }
    public class BlackMan : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("Black");
        }

        public void Talk()
        {
            Console.WriteLine("Black Talk");
        }
    }
}
