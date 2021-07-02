using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.AbstractClasses
{
    public abstract class GeeksForGeeks : ICloneable
    {
        public abstract object Clone();

        public abstract void gfg();

        public string Test()
        {
            return "We are testing";
        }

        public virtual string VirtualTest()
        {
            return "We are testing in virtualmethod";
        }
    }
}
