using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_3
{
    class VirtualPet
    {
        private int hunger;
        private int water;
        private int insulin;

        public VirtualPet()
        {
            this.hunger = 30;
            this.water = 20;
            this.insulin = 40;
        }


        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Waste
        {
            get { return this.water; }
            set { this.water = value; }
        }

        public int Insulin
        {
            get { return this.insulin; }
            set { this.insulin = value; }
        }
        public void DogInfo()
        {
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Water: " + this.water);
            Console.WriteLine("Insulin: " + this.insulin);
        }

        public void FeedDog()
        {
            hunger += 10;
            water -= 10;
            insulin -= 10;
            Console.WriteLine("Ranger's new stats are:");
        }
        public void WaterDog()
        {
            water += 10;
            hunger -= 10;
            insulin -= 10;
            Console.WriteLine("Ranger's new stats are:");
        }
        public void GiveInsulin()
        {
            insulin += 10;
            water -= 10;
            hunger -= 10;
            Console.WriteLine("Ranger's new stats are:");
        }












    }
}