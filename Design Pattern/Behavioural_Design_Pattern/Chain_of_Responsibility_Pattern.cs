using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Behavioural_Design_Pattern
{
    internal class Chain_of_Responsibility_Pattern
    {
        public abstract class Handler
        {
            public abstract void Handlrequest();
        }

        class ConcretHandl1 : Handler
        {
            public override void Handlrequest()
            {
                throw new NotImplementedException();
            }
        }

        class ConcretHandl2 : Handler
        {
            public override void Handlrequest()
            {
                throw new NotImplementedException();
            }
        }
    }
}
