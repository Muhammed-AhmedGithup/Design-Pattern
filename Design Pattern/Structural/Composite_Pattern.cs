using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural
{
    internal class Composite_Pattern
    {

        public interface ISructure
        {
            public void Enter();
            public void Exit();
            public void Location();
            public string GetName();

        }

        public class Housing : ISructure
        {
            private string Address;
            private List<ISructure> sructures;

            public Housing(string address)
            {
                sructures = new List<ISructure>();
                this.Address = address;
            }
           
            

            public int AddStructure(ISructure ructure)
            {
                sructures.Add(ructure);
                return sructures.Count-1;
            }
            public ISructure GetStructure(int number)
            {
                return this.sructures[number];
            }

            public string GetName()
            {
                return this.Address;
            }

            public void Enter()
            {
                Console.WriteLine(this.GetName() + "enter");
            }

            public void Exit()
            {
                Console.WriteLine(this.GetName() + "exite");
                
            }

            public void Location()
            {
                Console.WriteLine("You are currently in " +
                this.GetName() + ". It has ");

            }
        }



        class Room : ISructure
        {
            private string Name;

            public Room(string name)
            {
                Name = name;
            }
            public void Enter()
            {
                Console.WriteLine("You have entered the " +
                this.GetName());
            }

            public void Exit()
            {
                Console.WriteLine("You have left the " +
                this.GetName();

            }

            public string GetName()
            {
                return this.Name;
            }

            public void Location()
            {
                Console.WriteLine("You are currently in the" +
                this.GetName());

            }
        }



    }
}
