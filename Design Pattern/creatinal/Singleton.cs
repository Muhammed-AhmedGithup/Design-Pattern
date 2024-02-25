using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.creatinal
{
    public class Singleton
    {
        private static  Singleton singleton=null;

        private Singleton() { }

        public static Singleton Instance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }

    }
}
