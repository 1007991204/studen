using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder
{
    public abstract class ICreateComputer
    {
        public abstract CreatemyComputer CreateCup(string cpu);
        public abstract CreatemyComputer CreateMotherboard(string motherboard);
        public abstract Computer GetComputer();
    }
    /// <summary>
    /// 创建者
    /// </summary>
    public class CreatemyComputer : ICreateComputer
    {
        public Computer Computer { get; set; } = new Computer();
        public override CreatemyComputer CreateCup(string cpu)
        {
            this.Computer.Cup = cpu;
            return this;
        }

        public override CreatemyComputer CreateMotherboard(string motherboard)
        {
            this.Computer.Motherboard = motherboard;
            return this;
        }
        public override Computer GetComputer()
        {
            return this.Computer;
        }
    }
    /// <summary>
    /// 导演
    /// </summary>
    public class Director
    {
        public Director(CreatemyComputer createComputer)
        {
            Console.WriteLine(createComputer.CreateCup("cpu").CreateMotherboard("主板").GetComputer().Cup);
        }
    }
}
