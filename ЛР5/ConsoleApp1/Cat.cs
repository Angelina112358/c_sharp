using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cat : Pet
    {
        private string coatColor;
        public string CoatColor
        {
            get { return coatColor; }
            set { coatColor = value; }
        }
        public Cat() { }
        public Cat(float weight, float height, int normalAmountOfFood, string coatColor)
                                : base(weight, height, normalAmountOfFood)
        {
            this.coatColor = coatColor;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Цвет шерсти: " + coatColor);
        }
        public override void Feel()
        {
            Satiety = Satiety + 10;
            Energy = Energy + 10;
            Happiness = Happiness + 5;
            Sleep = Sleep + 5;
            base.Feel();
        }
        public override void Hunt()
        {
            if (Energy == 0) Console.WriteLine("Пополните энергию питомца");
            else
            {
                Energy = Energy - 10;
                Satiety = Satiety - 5;
                Happiness = Happiness + 10;
                Sleep = Sleep + 10;
            }
            base.Hunt();
        }
        public override void Caress()
        {
            Sleep = Sleep + 5;
            Happiness = Happiness + 10;
            base.Caress();
        }
        public override void Drowsiness()
        {
            Sleep = 0;
            Satiety = 0;
            Energy = Energy + 20;
            base.Drowsiness();
        }
    }
}
