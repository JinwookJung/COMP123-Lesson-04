using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123___Lesson___Part02
{
    //CAHARACTER SUPER CLASS
    class Characater
    {
        //PRIVATE PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++
        protected int health;
        protected int smarts;
        protected string gender;
        protected string name;
        
        //CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Characater(string name, int health, int smarts, string gender)
        {
            this.name = name;
            this.health = health;
            this.smarts = smarts;
            this.gender = gender;
        }
        //PROTECTED METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++
        protected void showProfile()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("Name: {0}", this.health);
            Console.WriteLine("Name: {0}", this.smarts);
            Console.WriteLine("Name: {0}", this.gender);
            Console.WriteLine("++++++++++++++++++++++++++++++");
        }
        
            
    }
}
