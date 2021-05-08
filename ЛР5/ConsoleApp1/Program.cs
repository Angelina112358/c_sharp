using System;

namespace ConsoleApp1
{
    class Animal
    {
        protected float weight;
        protected float height;
        protected int normalAmountOfFood;
        public Animal() { }
        public Animal(float weight, float height, int normalAmountOfFood)
        {
            this.weight = weight;
            this.height = height;
            this.normalAmountOfFood = normalAmountOfFood;
        }
        public virtual void ShowInformation()
        {
            Console.Write("Вес: {0} кг\n" +
                "Рост: {1} см\n" +
                "Ежедневная норма потребления пищи: {2}\n",
                weight, height, normalAmountOfFood);
        }
        class Animals
        {
            Animal[] arr;
            public Animals(int size) { arr = new Animal[size]; }
            public Animal this[int index]
            {
                get
                {
                    return arr[index];
                }
                set
                {
                    arr[index] = value;
                }
            }
        }
    }
    class Pet : Animal 
    {
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
        public Pet() { }
        public Pet(float weight, float height, int normalAmountOfFood) : base(weight, height, normalAmountOfFood) { }
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
    class Cat : Pet
    {
        private string coatColor;
        public string CoatColor
        {
            get { return coatColor; }
            set { coatColor = value; }
        }
        public Cat(float weight, float height, int normalAmountOfFood, string coatColor)
                                : base(weight, height, normalAmountOfFood) 
        {
            this.coatColor = coatColor;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Цвет шерсти: "+coatColor);
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
    class Dog : Pet 
    {
        private string eyesColor;
        public string EyesColor 
        {
            get { return eyesColor; }
            set { eyesColor = value; }
        }
        public Dog() { }
        public Dog(float weight, float height, int normalAmountOfFood, string eyesColor)
                            : base(weight, height, normalAmountOfFood) 
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
    class Program
    {
        static void Main(string[] args)
        {
            float weight;
            float height;
            int normalAmountOfFood;
            string input;
            int number;
            string coatColor = "Черный";
            do
            {
                Console.WriteLine("Введите вес вашего питомца: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out weight));
            do
            {
                Console.WriteLine("Введите рост вашего питомца: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out height));
            do
            {
                Console.Clear();
                Console.WriteLine("Введите количество потребляемой пищи вашего питомца ежедневно: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out normalAmountOfFood));
            Cat cat = new Cat(weight, height, normalAmountOfFood, coatColor);
            Dog dog = new Dog(5, 10, 200, "Карий");
            while (true)
            {
                do
                {
                    Console.WriteLine("Выберите действие:\n" +
                        "1. Вывести информацию\n" +
                        "2. Показать состояние\n" +
                        "3. Покормить\n" +
                        "4. Охотиться\n" +
                        "5. Погладить\n" +
                        "6. Поспать");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) && (number != 1 || number != 2 || number != 3));
                Console.Clear();
                switch (number)
                {
                    case 1:
                        cat.ShowInformation();
                        break;
                    case 2:
                        cat.StateInformation();
                        break;
                    case 3:
                        cat.Feel();
                        break;
                    case 4:
                        cat.Hunt();
                        break;
                    case 5:
                        cat.Caress();
                        break;
                    case 6:
                        cat.Drowsiness();
                        break;
                }
            }
        }
    }
}
