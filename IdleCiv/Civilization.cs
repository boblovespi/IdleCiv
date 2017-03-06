using System;
using System.Drawing;

namespace Boblovespi.IdleCiv
{
    class Civilization
    {
        private float power;
        private int land, army, food, gold;
        private string name;

        private Random rand;
        private Color color;
        private OutputManager print;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Land
        {
            get
            {
                return land;
            }
        }

        public int Army
        {
            get
            {
                return army;
            }
        }

        public int Food
        {
            get
            {
                return food;
            }
        }

        public int Gold
        {
            get
            {
                return gold;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public Civilization(string name, Color color, OutputManager output)
        {
            this.name = name;
            this.color = color;
            land = 1;
            army = 100;
            food = 100;
            gold = 100;
            rand = new Random();
            print = output;

            print.FancyWriteLine("The kingdom of " + name + " has been created!", color);
        }

        public void Update()
        {
            food += land; // land generates food
            food -= army; // army takes food
        }
    }
}
