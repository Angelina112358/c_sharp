using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight;
            float height;
            int normalAmountOfFood;
            string name;
            string input;
            int number;
            string numberPet;
            string coatColor = "Черный";
            string eyesColor = "Зеленый";
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
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
            Pet pet = new Pet(name, weight, height, normalAmountOfFood);
            do
            {
                Console.Clear();
                Console.WriteLine("Выберите животное:\n" +
                    "1. Кот\n" +
                    "2. Собака\n");
                numberPet = Console.ReadLine();
            } while (numberPet != "1" && numberPet != "2");
            if (numberPet == "1") pet = new Cat(name, weight, height, normalAmountOfFood, coatColor);
            else if (numberPet == "2") pet = new Dog(name, weight, height, normalAmountOfFood, eyesColor);
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
                        "6. Уложить спать\n" +
                        "7. Сравнить животных");
                    input = Console.ReadLine();
                } while (!int.TryParse(input, out number) && (number <1 || number>7));
                Console.Clear();
                switch (number)
                {
                    case 1:
                        pet.ShowInformation();
                        break;
                    case 2:
                        pet.StateInformation();
                        break;
                    case 3:
                        pet.Feel();
                        break;
                    case 4:
                        pet.Hunt();
                        break;
                    case 5:
                        pet.Caress();
                        break;
                    case 6:
                        pet.Drowsiness();
                        break;
                    case 7:
                        List<BodyData> dic = new List<BodyData>();
                        dic.Add(new BodyData(name, weight, height, normalAmountOfFood));
                        dic.Add(new BodyData("Барсик",9, 10, 1));
                        dic.Add(new BodyData("Мурзик",8, 12, 2));
                        dic.Add(new BodyData("Дымка", 11, 9, 1));
                        dic.Add(new BodyData("Багира", 10, 8, 1));
                        dic.Add(new BodyData("Алиса", 7, 13, 1));
                        Console.WriteLine("Животные: ");
                        foreach (BodyData i in dic) 
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine("Отсортированные по весу: ");
                        dic.Sort();
                        foreach (BodyData i in dic) 
                        {
                            Console.WriteLine(i);
                        }
                        break;
                }
            }
        }
    }
}
