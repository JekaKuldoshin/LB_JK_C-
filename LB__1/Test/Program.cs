/* 4. Ввести целочисленный двухмерный рваный массив (jagged array),
состоящий из строк произвольной длины. После строк с максимальной
суммой элементов вставить копию строки с минимальной суммой элементов.
Реализовать функцию вычисления суммы строки.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        //нахождение суммы в строке
        public static int RowSum(int[][] arr, int n)
        {
            int a = 0;
            for (int i = 0; i < arr[n].Length; i++)
                a += arr[n][i];
            return a;
        }

        static int sum(int[] a)  // сумма елементов
        {

            int s = 0;

            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }

            return s;

        }

        static void Sort(int [][]arr, int a)
        {
            //int[][] arr2 = new int[a][];

            //int buffer;
            //for (int lineNum = 0; lineNum < arr.Length; lineNum++)
            //    for (int elementNum = 0; elementNum < arr[lineNum].Length; elementNum++)
            //        for (int k = elementNum + 1; k < arr[lineNum].Length; k++)
            //            if (arr[lineNum][elementNum] > arr[lineNum][k])
            //            {
            //                buffer = arr[lineNum][elementNum];
            //                arr[lineNum][elementNum] = arr[lineNum][k];
            //                arr[lineNum][k] = buffer;
            //            }
            for (int n = 0; n < arr.Length; n++)
            {
                for (int i = 1; i < arr.Length; i++) //проходимся по столбцам, начинаем с первого
                {
                    int sumPrevRows = 0; // сумма предыдущего столбца
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        sumPrevRows += arr[i-1][j];
                    }

                    int sumCurrentRows = 0;       // сумма текущего столбца
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        sumCurrentRows += arr[i][j];
                    }

                    if (sumPrevRows > sumCurrentRows) //если сумма предыдущего столбца больше чем текущего, то меняем местами столбцы
                    {
                        for (int k = 0; k < arr.Length; k++)
                        {
                            int temp = arr[k][i];
                            arr[k][i] = arr[k][i - 1];
                            arr[k][i - 1] = temp;
                        }
                    }
                }
            }



        }
        static void Main(string[] args)
        {
            //запрос на ввод количества строк массива
            Console.WriteLine("Введите количество строк массива:");
            int a = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[a][];

            //ввод чисел в массив
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Введите " + i + " строку (каждое число через пробел):");
                string s = Console.ReadLine();
                string[] s_arr = s.Split();

                arr[i] = new int[s_arr.Length];
                for (int j = 0; j < arr[i].Length; j++)
                    arr[i][j] = int.Parse(s_arr[j]);
            }

            //вывод массива
            Console.WriteLine("\nИзначальный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    System.Console.Write(arr[i][j] + " ");
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            Sort(arr, a);
            //int buffer;
            //for (int lineNum = 0; lineNum < arr.Length; lineNum++)
            //    for (int elementNum = 0; elementNum < arr[lineNum].Length; elementNum++)
            //        for (int k = elementNum + 1; k < arr[lineNum].Length; k++)
            //            if (arr[lineNum][elementNum] > arr[lineNum][k])
            //            {
            //                buffer = arr[lineNum][elementNum];
            //                arr[lineNum][elementNum] = arr[lineNum][k];
            //                arr[lineNum][k] = buffer;
            //            }


            //нахождение минимальной и максимальной строки

            //int max = RowSum(arr, 0);
            //int[] maxRow = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int tempMin = RowSum(arr, i);
            //    if (min > tempMin)
            //    {
            //        min = tempMin;

            //        for (i = 0; i < arr[a].Length; i++)
            //        {
            //            minRow = arr[i];
            //            arr[i] = arr[a - 1];
            //            arr[a - 1] = minRow;
            //        }

            //    }
            //    //int tempMax = RowSum(arr, i);
            //    //if (max < tempMax)
            //    //{
            //    //    max = tempMax;
            //    //    maxRow = arr[i];
            //    //}
            //}

            //запись изменений в новый массив
            //int[][] arr2 = new int[a][];
            //int min = RowSum(arr, 0);
            //int[] minRow = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int tempMin = RowSum(arr, i);
            //    int secondSum = RowSum(arr, i + 1);

            //    int[] secondRow = arr[i];

            //    if (min > tempMin)
            //    {
            //        min = tempMin;
            //        minRow = arr[i];
            //        arr2[i] = minRow;
            //        minRow = arr[i];
            //        arr[i] = minRow;
            //    }

            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr[i].Length; j++)
            //    {

            //        int secondSum = RowSum(arr, i + 1);
            //        int[] secondRow = arr[i];
            //        if (min > secondSum)
            //        {


            //            arr2[i] = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = arr2[i];



            //            //arr2[i] = arr[i];
            //            //arr2[i + 1] = minRow;

            //        }
            //        else if (secondSum > min)
            //        {
            //            arr2[i] = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = arr2[i];

            //            min = secondSum;
            //        }
            //    }
            //}

            //изменение исходного массива
            //arr = arr2;

            //вывод измененного исходного массива
            System.Console.WriteLine("Измененный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    System.Console.Write(arr[i][j] + " ");
                System.Console.WriteLine();
            }
            System.Console.WriteLine();


            System.Console.ReadKey();
        }
    }
}
