using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class LazyMan
    {
        private LazyMan() { }
        private static volatile LazyMan _lazyMan;//避免指针重排
        private static object o = new object();
        public static LazyMan getlazyMan()
        {
            if (_lazyMan == null)//解决抢锁资源
            {
                lock (o)    // lock是一个互斥锁，Monitor.Enter() Monitor.Exit()
                {
                    if (_lazyMan == null)
                        _lazyMan = new LazyMan();
                    // new LazyMan()
                    // 1. 开辟一块内存空间
                    // 2. 创建一个对象
                    // 3. 将对象指向内存空间
                    // 123  132 指针重排
                }
            }
            return _lazyMan;

        }
    }
}
