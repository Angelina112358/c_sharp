using System;

namespace ЛР3_Nature
{
    class Animal
    {
        //protected int numberOfIndividuals;
        private int numberOfIndividuals;
        public int NumberOfIndividuals
        {
            get { return numberOfIndividuals; }
            private set { numberOfIndividuals = value; }
        }
        protected int lifespan;
        protected float weight;
        protected float height;
        protected string typeOfFood;
        protected int normalAmountOfFood;
        protected float totalWeight;
        public Animal(int numberOfIndividuals, int lifespan, float weight, float height, string typeOfFood, int normalAmountOfFood)
        {
            this.numberOfIndividuals = numberOfIndividuals;
            this.lifespan = lifespan;
            this.weight = weight;
            this.height = height;
            this.typeOfFood = typeOfFood;
            this.normalAmountOfFood = normalAmountOfFood;
        }
        public void ShowInformation()
        {
            Console.WriteLine("Количество особей: {0}\n" +
                "Продолжительность жизни: {1} лет\n" +
                "Средний вес: {2} кг\n" +
                "Средний рост: {3} см\n" +
                "Тип питания: {4}\n" +
                "Ежедневная норма потребления пищи: {5}\n", 
                numberOfIndividuals, lifespan, weight, height, typeOfFood, normalAmountOfFood);
        }
        public void AddNumberOfInfividuals() 
        {
            string newNumberOfIndividuals;
            do
            {
                Console.Write("Введите новое количество особей: ");
                newNumberOfIndividuals = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(newNumberOfIndividuals, out numberOfIndividuals));
        }
        public void TotalWeight()
        {
            totalWeight = numberOfIndividuals * weight;
            Console.WriteLine("Общая масса всех животных: " + totalWeight);
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
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIndividuals;
            int lifespan;
            float weight;
            float height;
            string typeOfFood = "";
            int normalAmountOfFood;
            string input;
            int number = 0;
            do
            {
                Console.WriteLine("Введите количество особей животного: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out numberOfIndividuals));
            do
            {
                Console.WriteLine("Введите продолжительность жизни: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out lifespan));
            do
            {
                Console.WriteLine("Введите вес одной особи: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out weight));
            do
            {
                Console.WriteLine("Введите рост одной особи: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!float.TryParse(input, out height));
            do
            {
                Console.Clear();
                Console.WriteLine("Введите количество потребляемой пищи одной особью ежедневно: ");
                input = Console.ReadLine();
                Console.Clear();
            } while (!int.TryParse(input, out normalAmountOfFood));
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите тип питания:\n" +
                    "1. Травоядное\n" +
                    "2. Плотоядное\n" +
                    "3. Смешанный тип\n");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out number) || (number != 1 && number != 2 && number != 3));
            switch (number)
            {
                case 1:
                    typeOfFood = "Травоядное";
                    break;
                case 2:
                    typeOfFood = "Плотоядное";       
                    break;
                case 3:
                    typeOfFood = "Смешанный тип";
                    break;
            };
            Animal animals = new Animal(numberOfIndividuals, lifespan, weight, height, typeOfFood, normalAmountOfFood);
            while (true)
            {
                do
                {
                    //Console.Clear();
                    Console.WriteLine("Выберите действие:\n" +
                        "1. Вывести информацию\n" +
                        "2. Изменить количество особей\n" +
                        "3. Вывести общую массу животных\n");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) && (number != 1 || number != 2 || number != 3));
                switch (number)
                {
                    case 1:
                        animals.ShowInformation();
                        break;
                    case 2:
                        animals.AddNumberOfInfividuals();
                        break;
                    case 3:
                        animals.TotalWeight();
                        break;
                }
            }
        }
    }
}
