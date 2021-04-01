using System;

namespace Animal
{
    class Animal
    {
        private string kind;
        private  double weight;
        private string gender;
        private string name;
        public Animal()
        {

        }
        public Animal(string kind, double weight, string gender)
        {
            this.kind = kind;
            this.weight = weight;
            this.gender = gender;
        }
        public Animal(string kind, string name, double weight, string gender):this(kind, weight, gender)
        {
            this.name = name;
        }
        static public void SortKind(Animal[] animal, int size)
        {
            bool a = false, b=false;
            string kindOfAnimal = "Кот";
            Console.WriteLine("Вывод данных о животных: \"" + kindOfAnimal + "\"");
            for (int i = 0; i < size; i++)
            {
                if (a = animal[i].kind.CompareTo(kindOfAnimal) == 0)
                {
                    Console.WriteLine("\nКличка: " + animal[i].name + "\nВес: " + animal[i].weight +" кг"+ "\nПол: " + animal[i].gender);
                    b = true;
                }
            }
            if (b == false) Console.WriteLine("Таких животных, как \"" + kindOfAnimal + "\" нет\n");
        }
        static public void SortSex(Animal[] animal, int size)
        {
            bool a = false, b = false;
            string genderOfAnimal = "Самец";
            Console.WriteLine("\n\nВывод данных о животных: \"" + genderOfAnimal + "\"");
            for (int i = 0; i < size; i++)
            {
                if (a = animal[i].gender.CompareTo(genderOfAnimal) == 0)
                {
                    Console.WriteLine("\nЖивотное: " + animal[i].kind + "\nКличка: " + animal[i].name + "\nВес: " + animal[i].weight + " кг");
                    b = true;
                }
            }
            if (b == false) Console.WriteLine("Животных с таким полом, как \"" + genderOfAnimal + "\" нет");
        }
        static public void AverageWeight(Animal[] animal, int size)
        {
            string kindOfAnimal = "Кот";
            bool a, b=false;
            int counter = 0;
            double result=0;
            for (int i = 0; i < size; i++)
            {
                if (a = animal[i].kind.CompareTo(kindOfAnimal) == 0)
                {
                    counter++;
                    b = true;
                    result += animal[i].weight;
                }
            }
            if (b == false) Console.WriteLine("Таких животных, как \"" + kindOfAnimal + "\" нет\n");
            else
            {
                result = result / counter;
                Console.WriteLine("Средний вес таких животных, как\"" + kindOfAnimal + "\": " + result);
            }
        }
        static public void OutPut(Animal[] animal, int size)
        {
            for(int i=0; i<size; i++)
            {
                Console.WriteLine("\nЖивотное: " + animal[i].kind + "\nКличка: " + animal[i].name + "\nВес: " + animal[i].weight + " кг" + "\nПол: " + animal[i].gender);
            }
        }
    }
    class Program: Animal
    {
        static void Main(string[] args)
        {
            Animal[] animal = {
                new Animal("Кот","Мурзик", 2, "Самец"),
                new Animal("Собака", 4, "Самка"),
                new Animal("Кот","Барсик", 3, "Самец"),
                new Animal("Собака", "Бобик", 5, "Самка"),
                new Animal("Хомяк", 1, "Самка"),
            };
            SortKind(animal, animal.Length);
            //SortGender(animal, animal.Length);
            //AverageWeight(animal, animal.Length);
            //OutPut(animal, animal.Length);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
