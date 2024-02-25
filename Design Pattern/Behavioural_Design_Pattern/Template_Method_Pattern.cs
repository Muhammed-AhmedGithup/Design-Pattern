using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Behavioural_Design_Pattern
{
    internal class Template_Method_Pattern
    {
        public abstract class PastaDish
        {
            void makeRecipe()
            {
                boilWater();
              
                addPasta();
                cookPasta();
                drainAndPlate();
                addSauce();
                addProtein();
                addGarnish();
            }

            private void drainAndPlate()
            {
                throw new NotImplementedException();
            }

            private void cookPasta()
            {
                throw new NotImplementedException();
            }

            protected abstract void addPasta();
            protected abstract void addSauce();
            protected abstract void addProtein();
            protected abstract void addGarnish();
            private void boilWater()
            {
                Console.WriteLine("Boiling water");
            }

         }

        public class SpaghettiMeatballs : PastaDish
        {
            protected override void addGarnish()
            {
                throw new NotImplementedException();
            }

            protected override void addPasta()
            {
                throw new NotImplementedException();
            }

            protected override void addProtein()
            {
                throw new NotImplementedException();
            }

            protected override void addSauce()
            {
                throw new NotImplementedException();
            }
        }
        public class PenneAlfredo : PastaDish
        {
            protected override void addGarnish()
            {
                throw new NotImplementedException();
            }

            protected override void addPasta()
            {
                throw new NotImplementedException();
            }

            protected override void addProtein()
            {
                throw new NotImplementedException();
            }

            protected override void addSauce()
            {
                throw new NotImplementedException();
            }
        }
    }
}
