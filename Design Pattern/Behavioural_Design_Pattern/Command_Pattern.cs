using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Design_Pattern.Behavioural_Design_Pattern
{
    //internal class Command_Pattern { }

    public abstract class Command
    {
        public abstract void excute();
        public abstract void unexcute();
         public abstract bool isReversion();
    }


    public class pasecommand : Command
    {
        private Document doocument;
        private int position;
        private string text;

        public pasecommand(Document document, int position, string text)
        {
            this.document = document;
            this.position = position;
            this.text = text;
        }

        public override void excute()
        {
       

        }

        public override bool isReversion()
        {
            return true;
        }

        public override void unexcute()
        {
            
        }

       
    }


}
