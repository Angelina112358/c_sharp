using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog : Pet
    {
        private string eyesColor;
        public string EyesColor
        {
            get { return eyesColor; }
            set { eyesColor = value; }
        }
        public Dog(string name, float weight, float height, int normalAmountOfFood, string eyesColor)
                            : base(name, weight, height, normalAmountOfFood)
        {
            this.eyesColor = eyesColor;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Цвет глаз: " + eyesColor);
        }
        public override void Feel()
        {
            Satiety = Satiety + 20;
            Energy = Energy + 15;
            Happiness = Happiness + 10;
            Sleep = Sleep + 10;
            base.Feel();
        }
        public override void Hunt()
        {
            base.Hunt();
            if (Energy == 0) Console.WriteLine("Пополните энергию питомца");
            else
            {
                Energy = Energy - 5;
                Satiety = Satiety + 5;
                Happiness = Happiness + 15;
                Sleep = Sleep + 15;
            }
        }
        public override void Caress()
        {
            Sleep = Sleep + 5;
            Happiness = Happiness + 5;
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
