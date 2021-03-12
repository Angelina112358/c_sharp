using System;

namespace Виселица1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string wordString = Console.ReadLine();
            char[] word = wordString.ToCharArray();
            int mistake = 0;
            int noMistake = 0;
            Console.Clear();
            string allEnterLetter = "";
            char[] trueLetters = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                trueLetters[i] = '?';
            }
            while (true)
            {
                char letter;
                bool repeatingLetter = true;
                while (true)
                {
                    Console.WriteLine("Введите букву: ");
                    string letterString = Console.ReadLine();
                    Console.Clear();
                    bool oneLetter = char.TryParse(letterString, out letter);
                    if (oneLetter)
                    {
                        for (int i = 0; i < allEnterLetter.Length; i++)
                        {
                            if (allEnterLetter[i] == letter)
                            {
                                repeatingLetter = false;
                                break;
                            }
                        }
                        if (repeatingLetter)
                        {
                            allEnterLetter += letter;
                        }
                        break;
                    }
                    else Console.WriteLine("Введите только одну букву");
                }
                bool existLetter = false;
                if (repeatingLetter)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == letter)
                        {
                            trueLetters[i] = letter;
                            existLetter = true;
                            noMistake++;
                        }
                    }
                    if (existLetter == true)
                    {
                        Console.WriteLine("Такая буква есть");
                    }
                }
                else Console.WriteLine("Такую букву вы уже вводили");
                Console.WriteLine("Введеные буквы:" + allEnterLetter);
                Console.WriteLine(trueLetters);
                if (!existLetter && repeatingLetter)
                {
                    Console.WriteLine("Такой буквы нет");
                    mistake++;
                }
                Console.WriteLine("Количество ошибок: " + mistake + " из 7");
                if (mistake == 7)
                {
                    Console.WriteLine("Вы проиграли");
                    return 0;
                }
                if (noMistake == word.Length)
                {
                    Console.WriteLine("Вы выйграли");
                    return 0;
                }  
            }
        }
    }
}
