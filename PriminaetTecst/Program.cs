using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriminaetTecst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, программа работает на нахождении самого большого и маленького слова. Напишите предложение где надо найти слово");
            string text = Console.ReadLine();
            Console.WriteLine("1 находит самре маленькое слово, а 2 находит самое большое слово");
            int condition = Convert.ToInt32(Console.ReadLine());//выбор
            switch (condition)// метод свитч с выбором метода
            {
                case 1:
                    TecstMin(text);
                    break;
                case 2:
                    TecstMax(text);
                    break;
                default:
                    Console.WriteLine("неправильная цифра");
                    break;
            }
          
            Console.ReadKey();
        }
        static void TecstMin (string text)//метод по нахождению самого маленького слова
        {
            string[] words = text.Split(' ');// запись слов отделённые пробелом
            string MaxLength = words[0];//пустое место под самое маленькое слово
            for (int i=0; i<words.Length; i++)//цикл, перебор массива
            {
                if(words[i].Length < MaxLength.Length)// условие по нахождению маленького слова
                {
                    MaxLength = words[i];//запись слова в пустое место
                }
            }
            Console.WriteLine(MaxLength);
        }
        static void TecstMax(string text)//метод по нахождению самого большого слова
        {
            string[] words = text.Split(' ');//запись слов отделённые пробелом
            string MinLenght = words[0];//пустое место под самое большое слово
            for (int i=0; i<words.Length; i++)//цикл, перебор массива
            {
                if(words[i].Length > MinLenght.Length)// условие по нахождению большого слова
                {
                    MinLenght = words[i];//запись слова в пустое место
                }
                
            }
            Console.WriteLine(MinLenght);
        }
    }
}
