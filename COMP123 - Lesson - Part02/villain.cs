using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123___Lesson___Part02
{
    class villain : Hero
    {
        //PRIVATE PROPERTY +++++++++++++++++++++++++++++++++++
        private string name;
        public villain(string name, int health, int smarts, string gender) : base(health, smarts, gender)
        {
            this.name = name;
        }

        //PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++
        public void doesBadThings() {
            Console.WriteLine("Doin' bad things...YEAH!");
        }
    }
}
