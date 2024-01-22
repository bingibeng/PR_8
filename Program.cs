using System;

namespace PR_8_VS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {    
                Console.Write("Нажмите Y чтобы продолжить и N чтобы прекратить ");     
                string select_key = Console.ReadLine();

                switch (select_key)
                {
                    case "Y":

                        try

                        {
                            Console.Title = "Практическая работа № 8"; // заголовок консоли
                            Console.ForegroundColor = ConsoleColor.Black; // цвет шрифта
                            Console.BackgroundColor = ConsoleColor.White; // цвет фона шрифта
                            Console.WriteLine("Здравствуйте!");

                            int a, b;

                            Console.Write("Введите a = ");
                            a = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите b = ");
                            b = Int32.Parse(Console.ReadLine());

                            int stop = (a > b) ? a : b; // проверка условия: если истина - a, ложь - b
                            int div = 1, max_div = 0;

                            do  // начало цикла do...while
                            {
                                if (a % div == 0 && b % div == 0)
                                {
                                    max_div = div;
                                }
                                div++;
                            }
                            while (div <= stop);

                            Console.WriteLine("Наибольший общий делитель " + a + " и " + b + " = " + max_div);
                        }
                        catch (FormatException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: введите число, а не cимвол");
                        }

                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка: что-то пошло не так");
                            Console.WriteLine(e.Message);       
                        }
                        Console.ReadLine();
                        Console.Clear ();
                        break;

                    case "N":
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                       
                }
                  
            }
        }
    }
}

