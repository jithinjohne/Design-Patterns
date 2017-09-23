using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class SamsungFactory : IGadgetFactory
    {
        public Phone CreatePhone()
        {
            return new SamsungGalaxy8();
        }

        public Tablet CreateTablet()
        {
            return new SamsungTabA();
        }
    }
}
