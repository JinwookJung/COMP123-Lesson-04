using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123___Lesson___Part02
{
    class Hero
    {
        //PRIVATE PROPERTY +++++++++++++++++++++++++++++++++++++++++++++++
        private bool bravery = true;
        private int health;
        private int smarts;
        private string gender;

        //CONSTRUCTOR ++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Hero(int health, int smarts, string gender)
        {
            this.health = health;
            this.smarts = smarts;
            this.gender = gender;

            // "this" means inside of class.

        }
        public void doesGoodThings(){
        Console.WriteLine("Doin' good things..YEAH!");
        }
    }
}
