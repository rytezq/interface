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
            Dog sharik = new Dog();
            sharik.Voice();
            Parrot kesha = new Parrot();
            kesha.Voice();
            Cat kotyara = new Cat();
            Console.WriteLine($"Введите имя кота(кошки)");
            kotyara.name = Console.ReadLine();
            Console.WriteLine($"Введите пол");
            kotyara.gender = Console.ReadLine();
            Console.WriteLine($"Введите возвраст");
            kotyara.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Введите вес");
            kotyara.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ваш питомец породистый (Да/Нет)");
            if (Console.ReadLine().ToLower().Trim() == "да")
            {
                kotyara.breed = true;
            }
            else if (Console.ReadLine().ToLower().Trim() == "нет")
            {
                kotyara.breed = false;
            }
            Console.WriteLine($"Рассчет суточноый нормы, сухого и влажного корма, а так же воды");
            kotyara.EatNorm(kotyara.gender, kotyara.age, kotyara.weight, kotyara.breed);
            kotyara.Voice();
        }
    }
        interface IAnimal
        {
            void Voice();
        }
        class Cat : IAnimal
        {
            public string name;
            public string gender;
            public int age;
            public int weight;
            public bool breed;
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
                    Console.WriteLine("Неверный ввод или Ваш котяра умер(((((");
                }
            }
            public void EatNorm(string gender, int age, int weight, bool breed)
            {
                if (gender.ToLower() == "male")
                {
                    if (breed)
                    {
                        if (age <= 2)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 50-55 г; Норма жидкого корма: 180-200 г; Норма воды: 80 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 70-75 г; Норма жидкого корма: 240-260 г; Норма воды: 100 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 85-90 г; Норма жидкого корма: 300-320 г; Норма воды: 120 мл");
                            }
                        }
                        else if (age <= 7)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 40-45 г; Норма жидкого корма: 150-170 г; Норма воды: 70 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 55-60 г; Норма жидкого корма: 200-220 г; Норма воды: 90 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 70-75 г; Норма жидкого корма: 250-270 г; Норма воды: 110 мл");
                            }
                        }
                        else
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 35-40 г; Норма жидкого корма: 130-150 г; Норма воды: 60 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 50-55 г; Норма жидкого корма: 170-190 г; Норма воды: 80 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 60-65 г; Норма жидкого корма: 210-230 г; Норма воды: 100 мл");
                            }
                        }
                    }
                    else
                    {
                        if (age <= 2)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 55-60 г; Норма жидкого корма: 200-220 г; Норма воды: 70 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 75-80 г; Норма жидкого корма: 260-280 г; Норма воды: 90 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 90-95 г; Норма жидкого корма: 320-340 г; Норма воды: 110 мл");
                            }
                        }
                        else if (age <= 7)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 45-50 г; Норма жидкого корма: 170-190 г; Норма воды: 60 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 60-65 г; Норма жидкого корма: 220-240 г; Норма воды: 80 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 75-80 г; Норма жидкого корма: 270-290 г; Норма воды: 100 мл");
                            }
                        }
                        else
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 40-45 г; Норма жидкого корма: 150-170 г; Норма воды: 50 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 55-60 г; Норма жидкого корма: 190-210 г; Норма воды: 70 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 65-70 г; Норма жидкого корма: 230-250 г; Норма воды: 90 мл");
                            }
                        }
                    }
                }
                else if (gender.ToLower() == "female")
                {
                    if (breed)
                    {
                        if (age <= 2)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 45-50 г; Норма жидкого корма: 160-180 г; Норма воды: 70 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 65-70 г; Норма жидкого корма: 220-240 г; Норма воды: 90 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 80-85 г; Норма жидкого корма: 280-300 г; Норма воды: 110 мл");
                            }
                        }
                        else if (age <= 7)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 35-40 г; Норма жидкого корма: 130-150 г; Норма воды: 60 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 50-55 г; Норма жидкого корма: 180-200 г; Норма воды: 80 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 65-70 г; Норма жидкого корма: 230-250 г; Норма воды: 100 мл");
                            }
                        }
                        else
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 30-35 г; Норма жидкого корма: 110-130 г; Норма воды: 50 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 45-50 г; Норма жидкого корма: 150-170 г; Норма воды: 70 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 55-60 г; Норма жидкого корма: 190-210 г; Норма воды: 90 мл");
                            }
                        }
                    }
                    else
                    {
                        if (age <= 2)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 50-55 г; Норма жидкого корма: 180-200 г; Норма воды: 60 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 70-75 г; Норма жидкого корма: 240-260 г; Норма воды: 80 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 85-90 г; Норма жидкого корма: 300-320 г; Норма воды: 100 мл");
                            }
                        }
                        else if (age <= 7)
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 40-45 г; Норма жидкого корма: 150-170 г; Норма воды: 50 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 55-60 г; Норма жидкого корма: 200-220 г; Норма воды: 70 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 70-75 г; Норма жидкого корма: 250-270 г; Норма воды: 90 мл");
                            }
                        }
                        else
                        {
                            if (weight <= 3)
                            {
                                Console.WriteLine("Норма сухого корма: 35-40 г; Норма жидкого корма: 130-150 г; Норма воды: 40 мл");
                            }
                            else if (weight <= 6)
                            {
                                Console.WriteLine("Норма сухого корма: 50-55 г; Норма жидкого корма: 170-190 г; Норма воды: 60 мл");
                            }
                            else
                            {
                                Console.WriteLine("Норма сухого корма: 60-65 г; Норма жидкого корма: 210-230 г; Норма воды: 80 мл");
                            }
                        }
                    }
                }
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
