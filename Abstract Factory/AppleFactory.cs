using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class AppleFactory : IGadgetFactory
    {
        public Phone CreatePhone()
        {
            return new IPhoneX();
        }

        public Tablet CreateTablet()
        {
            return new IPad();
        }
    }
}
