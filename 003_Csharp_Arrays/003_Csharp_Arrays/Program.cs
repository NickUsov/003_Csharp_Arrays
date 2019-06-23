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
            double max_ = 0, min_ = 0;
            Random rnd_ = new Random();
            double[] a = new double[5];
            double[,] b = new double[3, 4];
            for (int i = 0; i < 5; i++)
                a[i] = rnd_.Next(25)/10.0;
            for (var i = 0; i < 3; i++)
                for (var j = 0; j < 4; j++)
                    b[i, j] = rnd_.Next(25)/10.0;
            Console.WriteLine("Одномерный массив");
            foreach (var x in a)
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
            foreach (var x in a)
                Console.Write(x + " ");
            Console.WriteLine();
            foreach (var x in a)
                foreach (var y in b)
                    if (x == y)
                        max_ = x;
            Console.WriteLine("Общий максимум " + max_);
            Array.Reverse(a);
            foreach (var x in a)
                foreach (var y in b)
                    if (x == y)
                        min_ = x;
            Console.WriteLine("Общий минимум " + min_);
            double sum_ = 0;
            foreach (var x in a)
                sum_ += x;
            foreach (var x in b)
                sum_ += x;
            Console.WriteLine("Сумма " + sum_);
            double mul = 1;
            foreach (var x in a)
                if (x != 0)
                    mul *= x;
            foreach (var x in b)
                if (x != 0)
                    mul *= x;
            Console.WriteLine("Произведение " + mul);
            double sumP = 0;
            for (int i = 0; i < 5; i++)
                if (i != 0 && i % 2 == 0)
                    sumP += a[i];
            Console.WriteLine("Сумма четных элементов 1-го массива " + sumP);
            double sumB = 0;
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


            //4. Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых
            //двух массивов без повторений.

            Console.WriteLine("4. задание");
            Console.WriteLine("Enter length of 1 array");
            int arr1_length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length of 2 array");
            int arr2_length = int.Parse(Console.ReadLine());
            int[] arr1 = new int[arr1_length];
            int[] arr2 = new int[arr2_length];
            for (int i = 0; i < arr1_length; i++)
            {
                arr1[i] = rnd.Next(20);
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2_length; i++)
            {
                arr2[i] = rnd.Next(20);
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            int[] arr3 = new int[0];
            int c = 0;
            for(int i=0;i<arr1_length;i++)
            {
                for(int j=0;j<arr2_length;j++)
                {
                    if(arr1[i]==arr2[j])
                    {
                        Array.Resize(ref arr3, arr3.Length + 1);
                        arr3[c] = arr1[i];
                        c++;
                    }
                }
            }
            int[] arr_res = arr3.Distinct().ToArray();
            Console.WriteLine("Result:");
            for (int i = 0; i < arr_res.Length; i++)
                Console.Write(arr_res[i] + " ");
            Console.WriteLine();

            //5. Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от -100 до 100. Определить 
            //сумму элементов массива, расположенных между минимальным и максимальным элементами.

            Console.WriteLine("5. задание");
            int k = 0;
            int[,] array = new int[5, 5];
            int[] buf = new int[25];
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                    buf[k] = array[i, j];
                    k++;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int _min = buf.Min();
            int _max = buf.Max();
            int index_min = Array.IndexOf(buf, _min);
            int index_max = Array.LastIndexOf(buf, _max);
            if (index_min > index_max)
            {
                index_max = Array.LastIndexOf(buf, _min);
                index_min = Array.IndexOf(buf, _max);
            }
            int result = 0;
            for (int i = index_min; i < index_max + 1; i++)
                result += buf[i];
            Console.WriteLine($"Sum all elements from {_min} to {_max} is {result}");
        }
    }
}
