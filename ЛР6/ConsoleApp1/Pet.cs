using System;

namespace ConsoleApp1
{
    class Pet : BodyData
    {
        public virtual void ShowInformation()
        {
            Console.Write("Имя: {0}\n" +
                "Вес: {1} кг\n" +
                "Рост: {2} см\n" +
                "Ежедневная норма потребления пищи: {3}\n",
                Name, Weight, Height, NormalAmountOfFood);
        }
        private int satiety = 0;
        public int Satiety
        {
            get { return satiety; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Питомец не голоден");
                }
                else satiety = value;
            }
        }
        private int energy;
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Энергия питомца переполнена");
                }
                else energy = value;
            }
        }
        private int happiness = 0;
        public int Happiness
        {
            get { return happiness; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Питомец счастлив");
                }
                else happiness = value;
            }
        }
        private int sleep = 0;
        public int Sleep
        {
            get { return sleep; }
            set
            {
                if (value == 105 || value == 110)
                {
                    Console.WriteLine("Питомец хочет спать");
                }
                else sleep = value;
            }
        }
        public Pet(string name, float weight, float height, int normalAmountOfFood) : base(name, weight, height, normalAmountOfFood) { }
        public virtual void Feel()
        {
            Console.WriteLine("Уровень сытости: " + Satiety + " из 100");
        }
        public virtual void Hunt()
        {
            Console.WriteLine("Уровень энергии " + Energy + " из 100");
        }
        public virtual void Caress()
        {
            Console.WriteLine("Уровень счастья: " + Happiness + " из 100");
        }
        public virtual void Drowsiness()
        {
            Console.WriteLine("Уровень сонливости: " + Sleep + " из 100");
        }
        public void StateInformation()
        {
            Console.WriteLine("Уровень сытости: " + Satiety + " из 100");
            Console.WriteLine("Уровень энергии " + Energy + " из 100");
            Console.WriteLine("Уровень счастья: " + Happiness + " из 100");
            Console.WriteLine("Уровень сонливости: " + Sleep + " из 100");
        }
    }
}
