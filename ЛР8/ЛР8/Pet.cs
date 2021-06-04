using System;

namespace ConsoleApp1
{
    delegate void StateHandler(string message);
    class Pet : BodyData
    {
        public event StateHandler Done;
        public event StateHandler Doing;
        StateHandler _del;
        public void RegisterSatietyHandler(StateHandler del) 
        {
            _del = del;
        }
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
                    if (Done != null)
                        Done("Питомец не голоден");
                }
                else if (value < 0)
                {
                    if (Doing != null)
                        Doing("Питомец голоден");
                }
                else
                {
                    if (Doing != null)
                        Doing("Вы покормили питомца");
                    satiety = value;
                }
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
                    if (Done != null)
                         Done("Энергия питомца переполнена");
                }
                else
                {
                    if (Doing != null)
                        Doing("Вы измени состояние энергии питомца");
                    energy = value; 
                }
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
                    if (Done != null)
                        Done("Питомец счастлив");
                }
                else
                {
                    if (Doing != null)
                        Doing("Вы изменили эмоциональное состояние питомца");
                    happiness = value;
                }
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
                    if (Done != null)
                        Done("Питомец хочет спать");
                }
                else
                {
                    if (Doing != null)
                        Doing("У питомца есть запас бодрости");
                    sleep = value;
                }
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