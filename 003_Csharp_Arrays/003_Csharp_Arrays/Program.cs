using System;
using System.Linq;

namespace _003_Csharp_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. В одномерном массиве (введённом с клавиатуры, заполненным случайными числами) найти минимальное и максимальное
            //значение, сумму и произведение чисел. Вывести на экран.
            Console.WriteLine("1. задание");
            int size, sum = 0, min = 0, max = 0, mult = 1;
            Console.WriteLine("Введите размер массива");
            size = int.Parse(Console.ReadLine());
            int[] myArr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                myArr[i] = rnd.Next(10);
            foreach (int x in myArr)
                Console.Write(x + " ");
            Console.WriteLine();
            foreach (int x in myArr)
                sum += x;
            Console.WriteLine($"Сумма элементов массива равна {sum}");
            foreach (int y in myArr)
                if (y != 0)
                    mult *= y;
            Console.WriteLine("Произведение элементов " + mult);
            min = myArr.Min();
            Console.WriteLine($"Минимум {min}");
            max = myArr.Max();
            Console.WriteLine($"Максимум {max}");

            //2.  Объявить одномерный (5 элементов ) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с
            //именем B. Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В 
            //случайными числами с помощью циклов. Вывести на экран значения массивов: массива А в одну  строку, массива В – в виде
            //матрицы. Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее 
            //произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.
            Console.WriteLine("2. задание");
            max = 0; min = 0;
            int[] a = new int[5];
            int[,] b = new int[3, 4];
            for (int i = 0; i < 5; i++)
                a[i] = rnd.Next(20);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    b[i, j] = rnd.Next(20);
            Console.WriteLine("Одномерный массив");
            foreach (int x in a)
                Console.Write(x + " ");
            Console.WriteLine();
            Console.WriteLine("Двумерный массив");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(b[i, j] + " ");
                Console.WriteLine();
            }
            Array.Sort(a);
            Console.WriteLine("Сортировка");
            foreach (int x in a)
                Console.Write(x + " ");
            Console.WriteLine();
            foreach (int x in a)
                foreach (int y in b)
                    if (x == y)
                        max = x;
            Console.WriteLine("Общий максимум " + max);
            Array.Reverse(a);
            foreach (int x in a)
                foreach (int y in b)
                    if (x == y)
                        min = x;
            Console.WriteLine("Общий минимум " + min);
            sum = 0;
            foreach (int x in a)
                sum += x;
            foreach (int x in b)
                sum += x;
            Console.WriteLine("Сумма " + sum);
            mult = 1;
            foreach (int x in a)
                if (x != 0)
                    mult *= x;
            foreach (int x in b)
                if (x != 0)
                    mult *= x;
            Console.WriteLine("Произведение " + mult);
            int sumP = 0;
            for (int i = 0; i < 5; i++)
                if (i != 0 && i % 2 == 0)
                    sumP += a[i];
            Console.WriteLine("Сумма четных элементов 1-го массива " + sumP);
            int sumB = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 != 0)
                        sumB += b[i, j];
                }
            }
            Console.WriteLine("Сумма элементов нечетных столбцов 2-го массива " + sumB);

            //3. Успеваемость студента хранятся в зубчатом массиве, где каждая строка – это оценки по одному предмету. Определить
            //средний бал по каждому предмету

            Console.WriteLine("3. задание");
            int[][] arr = new int[3][];
            arr[0] = new int[5];
            arr[1] = new int[6];
            arr[2] = new int[4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = rnd.Next(3) + 3;
            }
            foreach (int[] mas in arr)
            {
                foreach (int x in mas)
                    Console.Write(x + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
                double avg = (double)sum / arr[i].Length;
                Console.WriteLine("Средний бал по {0} предмету равен {1:F2} ", i + 1, avg);
            }
        }
    }
}
