using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        interface IAnimal
        {
            void Voice();
        }
        class Cat : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("мяу-мяу");
            }
            public void LivesCount()
            {
                Console.WriteLine("Введите какую жизнь живет  котяра");
                int lives = Convert.ToInt32(Console.ReadLine());
                if (lives >= 1 && lives <= 8)
                {
                    Console.WriteLine($"Ваш котяра может прожить еще {9 - lives}");
                }
                else if (lives == 9)
                {
                    Console.WriteLine("Котяра проживает свою последнюю жизнь");
                }
                else
                {
                    Console.WriteLine("Ваш котяра умер(((((");
                }
            }
            public void EatNormDay(string gender, int age, int weight, bool breed)
            {
               
            }
        }
        class Dog : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("гав-гав");
            }
        }
        class Parrot : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("СВОБОДУ ПОПУГАЯМ");
            }
        }
    }
}
