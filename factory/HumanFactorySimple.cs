using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory
{
    public class HumanFactorySimple
    {

        public static T CreateHuman<T>() where T : class, IHuman
        {
            IHuman human = null;
            try
            {
                human = Activator.CreateInstance<T>() as IHuman;//通过反射创建
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return human as T;
        }
    }
}
