using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int z = x + y;
            Console.WriteLine($"Сумма = {z}");
            Console.WriteLine();
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сумму x+y:");
            int a = Convert.ToInt32(Console.ReadLine());

            int z = x + y;

            if (z == a)
            {
                Console.WriteLine("Правильно");
            }

            else
            {
                Console.WriteLine("Неправильно");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите сумму x+y:");
            int a = Convert.ToInt32(Console.ReadLine());

            int z = x + y;

            if (z == a)
            {
                Console.WriteLine("Правильно");
            }

            else
            {
                Console.WriteLine("Неправильно");

                if (z < a)
                {
                    Console.WriteLine("Должно быть меньше");
                }

                else
                {
                    Console.WriteLine("Должно быть больше");

                }
            }

            Console.WriteLine();
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введити оператор (+ или -)");
            string op = Console.ReadLine();

            if (op == "+")
            {
                int sum = x + y;
                Console.WriteLine("Введите сумму x+y:");
                int mySum = Convert.ToInt32(Console.ReadLine());

                if (sum == mySum)
                {
                    Console.WriteLine("Правильно");
                }

                else
                {
                    Console.WriteLine("Неправильно");

                    if (sum < mySum)
                    {
                        Console.WriteLine("Должно быть меньше");
                    }

                    else
                    {
                        Console.WriteLine("Должно быть больше");
                    }

                }
            }

            else
            {
                int dif = x - y;
                Console.WriteLine("Введите разность x-y:");
                int myDif = Convert.ToInt32(Console.ReadLine());

                if (dif == myDif)
                {
                    Console.WriteLine("Правильно");
                }

                else
                {
                    Console.WriteLine("Неправильно");

                    if (dif < myDif)
                    {
                        Console.WriteLine("Должно быть меньше");
                    }

                    else
                    {
                        Console.WriteLine("Должно быть больше");
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введити оператор (+ или -)");
            string op = Console.ReadLine();

            if (op == "+")
            {
                int sum = x + y;
                int i = 0;
                int mySum = 0;

                for (; i < 3 && sum != mySum; i++)
                {
                    Console.WriteLine("Введите сумму x+y:");
                    mySum = Convert.ToInt32(Console.ReadLine());

                    if (sum == mySum)
                    {
                        Console.WriteLine("Правильно");
                    }

                    else
                    {
                        Console.WriteLine("Неправильно");

                        if (sum < mySum)
                        {
                            Console.WriteLine("Должно быть меньше");
                        }

                        else
                        {
                            Console.WriteLine("Должно быть больше");
                        }
                    }

                }
            }

            else if (op == "-")
            {
                int dif = x - y;
                int i = 0;
                int myDif = 0;

                for (; i < 3 && dif != myDif; i++)
                {
                    Console.WriteLine("Введите разность x-y:");
                    myDif = Convert.ToInt32(Console.ReadLine());

                    if (dif == myDif)
                    {
                        Console.WriteLine("Правильно");
                    }

                    else
                    {
                        Console.WriteLine("Неправильно");

                        if (dif < myDif)
                        {
                            Console.WriteLine("Должно быть меньше");
                        }

                        else
                        {
                            Console.WriteLine("Должно быть больше");
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("Неверный оператор");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите k:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите h:");
            int h = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int i = 0;
            int z = x + y + b + k + h;

            for (; i < 2 && a != z; i++)
            {
                Console.WriteLine("Введите сумму x+y+b+k+h:");
                a = Convert.ToInt32(Console.ReadLine());

                if (z == a)
                {
                    Console.WriteLine("Правильно");
                }

                else
                {
                    Console.WriteLine("Неправильно");

                    if (z < a)
                    {
                        Console.WriteLine("Должно быть меньше");
                    }

                    else
                    {
                        Console.WriteLine("Должно быть больше");

                    }
                }
            }

            Console.WriteLine();



        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            Console.WriteLine("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите b:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите k:");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите h:");
            int h = Convert.ToInt32(Console.ReadLine());

            int a = 0;
            int i = 0;
            int z = x + y + b + k + h;

            for (; i < 2 && a != z; i++)
            {
                Console.WriteLine("Введите сумму x+y+b+k+h:");
                a = Convert.ToInt32(Console.ReadLine());

                if (z == a)
                {
                    Console.WriteLine("Правильно");           
                }

                else
                {
                    Console.WriteLine("Неправильно");

                    if (z < a)
                    {
                        Console.WriteLine("Должно быть меньше");
                    }

                    else
                    {
                        Console.WriteLine("Должно быть больше");

                    }
                }
            }

            if(z == a)
            {
                Console.WriteLine("Задача была решена верно");
            }

            else
            {
                Console.WriteLine("Задача была решена неверно");
            }

            Console.WriteLine();
        }
    



            /// <summary>
            /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
            /// </summary>
            public static void B3_P8_9_CircleArea()
        {

        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {

        }
    }

}