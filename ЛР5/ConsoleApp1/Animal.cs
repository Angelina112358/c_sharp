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
}
