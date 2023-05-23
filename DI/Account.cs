using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    internal class Account : IAcccount
    {
        public void Prient()
        {
            Console.WriteLine($"DI注入");
        }
    }
}
