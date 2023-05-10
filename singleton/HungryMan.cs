using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class HungryMan
    {
        // 单例设计模式：
        // 1. 构造函数私有化
        // 2. 静态只读私有字段
        // 3. 静态公开的获取私有字段的方法


        // 缺点？
        // 造成一定的资源浪费
        private HungryMan() { }
        private static readonly HungryMan _hungryMan = new HungryMan();
        public static HungryMan GetHungryMan()
        {
            return _hungryMan;
        }
    }
}
