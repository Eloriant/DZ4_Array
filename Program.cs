using System;

namespace DZ4_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //пользователь вводит длину массива
            Console.Write("Введите длину массива = ");

            int n = Convert.ToInt32(Console.ReadLine()); // значение массива задает пользователь
            int[] a = new int[n]; // a - это массив

            Random random = new Random(); // random ее тип данных рандом

            for (int i = 0; i < a.Length; i++) // всегда знак <
            {
                a[i] = random.Next(-100, 100); // диапозон чисел в массиве
                Console.WriteLine(a[i] + " "); // вывод чисел массива
            }

            // Задание 1
            Console.WriteLine("Задание 1. Найти минимальный элемент массива");

            int min = a[0]; // а[0] первый элемент массива

            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i]) // сравниваем со значением ячейки
                {
                    min = a[i];
                }
            }
            Console.WriteLine(min);

            // Задание 2
            Console.WriteLine("Задание 2. Найти максимальный элемент массива");

            int max = a[0]; // в переменной а лежит ссылка на нулевой элемент, вписанный 0 в скобках говорит, чтоб никуда не смещался

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i]) // сравниваем со значением ячейки
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);

            // Задание 3
            Console.WriteLine("Задание 3. Найти индекс минимального элемента массива");

            min = 0;
            int minIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    minIndex = i;
                }

                a[i] = min;
            }
            Console.WriteLine(minIndex);

            // Задание 4
            Console.WriteLine("Задание 4. Найти индекс максимального элемента массива");

            max = 0;
            int maxIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    maxIndex = i;
                }

                a[i] = max;
            }
            Console.WriteLine(maxIndex);

            // Задание 5
            Console.WriteLine("Задание 5. Посчитать сумму элементов массива с нечетными индексами");

            int summ = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 != 0)
                {
                    summ = a[i] + summ;
                }
            }
            Console.WriteLine(summ);

            // Задание 6
            Console.WriteLine("Задание 6. Сделать реверс массива (массив в обратном направлении)");

            int b = 0;

            int half = n / 2;
            n -= 1;

            for (int i = 0; i <= half; i++)
            {
                b = a[i];
                a[i] = a[n];
                a[n] = b;

                n--;
                if (a[n] == a[i])
                { break; }

            }

            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine(a[i] + " ");
            }

            // Задание 7
            Console.WriteLine("Задание 7. Посчитать количество нечетных элементов массива");

            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);

            // Задание 8
            Console.WriteLine("Задание 8. Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2");

            b = 0;
            half = n / 2;

            n -= 1;

            for (int i = 0; i <= half; i++)
            {
                if (n % 2 == 0)
                {
                    n -= 1;

                    for (int j = half++; j <= n; j++)
                    {
                        b = a[i];
                        a[i] = a[half];
                        a[half] = b;
                        half++;
                        i++;
                    }
                }
                else
                {
                    for (int j = half; j <= n; j++)
                    {
                        b = a[i];
                        a[i] = a[half];
                        a[half] = b;
                        half++;
                        i++;

                    }


                }
            }

            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine(a[i] + " ");
            }

            // Задание 9

            Console.WriteLine("Задание 9. Отсортировать массив по возрастанию");

            for (int i = 0; i < a.Length; i++)
            {
                minIndex = i; // начинается отрезок с i элемента

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[minIndex]) // ищет индекс самого маленького элемента
                    {
                        minIndex = j;
                    }

                    int tmp = a[i];
                    a[i] = a[minIndex];
                    a[minIndex] = tmp;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }

            // Задание 10

            Console.WriteLine("Задание 10. Отсортировать массив по убыванию");


            for (int i = 0; i < a.Length; i++)
            {
                maxIndex = i; // начинается отрезок с i элемента

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[maxIndex]) // ищет индекс самого маленького элемента
                    {
                        maxIndex = j;
                    }

                    int tmp = a[i];
                    a[i] = a[maxIndex];
                    a[maxIndex] = tmp;
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }

            // Двумерные массивы

            Console.WriteLine("Двумерный массив");
            Console.Write("Введите количество строк = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] c = new int[n, m];
            Random r = new Random();

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = r.Next(10, 100);
                    Console.Write(c[i, j] + " "); // добавить пробел после значения, чтоб было красиво
                }
                Console.WriteLine();
            }

            // Задание 1

            Console.WriteLine("Задание 1. Найти минимальный элемент двумерного массива");

            min = c[0, 0];

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    if (min > c[i, j])
                    {
                        min = c[i, j];
                    }
                }
                Console.WriteLine(min);
            }
            // Задание 2
            Console.WriteLine("Задание 2. Найти максимальный элемент двумерного массива");

            max = c[0, 0];

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    if (max < c[i, j])
                    {
                        max = c[i, j];
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}
