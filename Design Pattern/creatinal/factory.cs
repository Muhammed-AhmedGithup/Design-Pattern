using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.creatinal
{
    public class Factory
    {
        
        public  Knife createKnife(string type)
        {
             Knife knife = null;

            if (type.Equals("steak"))
            {
                knife = new SteakKnife();
            }
            else if (type.Equals("chefs"))
            {
                knife = new ChefsKnife();
            }

            return knife;
        }
    }




    public class KnifeStore
    {
        private Factory factory;
        
        public KnifeStore(Factory factory)
        {
            this.factory = factory;
        }
        public Knife orderKnife(String knifeType)
        {
            Knife knife;
            
            knife = factory.createKnife(knifeType);
          
            knife.sharpen();
            knife.polish();
            knife.package();
            return knife;
        }
    }







    class Knife
    {
       
        public Knife() { }
       public void sharpen(){}
        public void polish(){}
        public void package(){ }

    }

    class SteakKnife:Knife { 
    
        public SteakKnife() { }
    }

    class ChefsKnife : Knife
    {

        public ChefsKnife() { }
    }
}
