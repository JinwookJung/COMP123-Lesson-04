using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123___Lesson___Part02
{
    class villain : Characater
    {
        //PRIVATE PROPERTY +++++++++++++++++++++++++++++++++++
        private bool courage = true;
        public villain(string name, int health, int smarts, string gender) 
            : base(name, health, smarts, gender)
        {
            this.showProfile();
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++
        public void doesBadThings() {
            Console.WriteLine("Doin' bad things...YEAH!");
        }
    }
}
