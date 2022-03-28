//                                         Лабораторная работа №1
//                                                Вариант 4

//Ввести  целочисленный двухмерныйрваный  массив  (jagged  array), состоящий из  строк  произвольной  длины. 
//После  строк  с  максимальной суммой элементов вставить копию строки с минимальной суммой элементов. 
//Реализовать функцию вычисления суммы строки.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB__1
{
    internal class Program
    {
        
        static int RowSum(int[][] arr, int n)             //\\ //\\  Функция суммирования строки //\\ //\\
        {
            int sum = 0;                                  //Переменная для суммы строки
            for (int i = 0; i < arr[n].Length; i++)      //Перебор строки по n-нному элементу
                sum += arr[n][i];                       //Накопление
            return sum;                                //Возращение переменной
        }

        static void AddArr(int[][] arr, int count)      //\\ //\\  Функция заполнения ступенчатого массива //\\ //\\
        {
            for (int i = 0; i < count; i++)                      
            {
                Console.WriteLine("Введите " + i + " строку (ввод выполняйте через пробел!)");
                string str = Console.ReadLine();                  //Ввод в консоль значений
                string[] str_arr = str.Split();                  //Разбитие и присваивание значений в массив

                arr[i] = new int[str_arr.Length];              //В массив заносим кол-во строк
                for (int j = 0; j < arr[i].Length; j++)       //Перебираем исходя из кол-ва стр. в массиве
                    arr[i][j] = int.Parse(str_arr[j]);       //Делаем переобразование в Int и заносим в массив
            }
        }

        static void WriteArr(int[][] arr)              //\\ //\\  Функция вывода ступенчатого массива //\\ //\\
        {
            for (int i = 0; i < arr.Length; i++)                 //Перебираем исходя из кол-ва стр. в массиве
            {
                for (int j = 0; j < arr[i].Length; j++)        //Перебираем исходя из кол-ва элем. в массиве
                    System.Console.Write(arr[i][j] + " ");    //Выводим на консоль ступенчатый массив, через пробел 
                System.Console.WriteLine();                  //После вывода n-ой строки 
            }
            System.Console.WriteLine();
        }

        public static int [] FunArr_Min(int[][] arr, int [] minRow)     //\\ //\\ Функция для нахождения Макс. и Мин. //\\ //\\
        {

            int min = RowSum(arr, 0);                       //Переменная с минимальной суммой строки

            for (int i = 1; i < arr.Length; i++)         //Перебираем строки
            {
                int tempMin = RowSum(arr, i);          //Доп. переменная для замен
                if (min > tempMin)                    //Если Мин. больше Доп.переменной идет замена
                {
                    min = tempMin;
                    minRow = arr[i];
                }
            }
            return minRow;
        }

        public static int [] FunArr_Max(int[][] arr, int[] maxRow)     //\\ //\\ Функция для нахождения Макс. и Мин. //\\ //\\
        {

            int min = RowSum(arr, 0);                       //Переменная с минимальной суммой строки
            int max = RowSum(arr, 0);                      //Переменная с максимальнй суммой строки

            for (int i = 1; i < arr.Length; i++)         //Перебираем строки
            {
                int tempMax = RowSum(arr, i);     //Доп. переменная для замен
                if (max < tempMax)               //Если Макс. меньше Доп.переменной идет замена
                {
                    max = tempMax;
                    maxRow = arr[i];
                }
            }
            return maxRow;
        }

        static int [][] ModifFunArr(int[][] arr, int[] minRow, int[] maxRow, int a)       //\\ //\\ Функция изменения массива //\\ //\\
        {
            int[][] arr2 = new int[a + 1][];                           //Создали новый рванный массив добавляем +1 место для новой строки
            for (int i = 0; i < arr.Length; i++)                      //Перебираем строки
            {
                if (maxRow == arr[i])                               //Если строка с максимальной суммой элементов ровняется строке, то вставить копию строки с минимальной суммой элементов. 
                {
                    arr2[i] = arr[i];                             //Перенесли данные в новый массив
                    arr2[i + 1] = minRow;                        //Перемещаем +1 строку и вставляем мин.строку
                    i++;
                    for (int j = i + 1; j < arr2.Length; j++)
                        arr2[j] = arr[j - 1];
                    break;
                }
                else
                    arr2[i] = arr[i];                      //Перемещаем данные в новый массив
            }

            arr = arr2;                                 //Переносим данные с нового массива в основой массив      
            return arr;                                //Возвращаем в Main
        }

        

        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество строк jagged массива:");
            int a = Convert.ToInt32(Console.ReadLine());                     //Запрашиваем кол. строк
            int[][] arr = new int[a][];                                     //Создали рванный массив и присволили кол. строк

            AddArr(arr, a);                                               //Переходим в функ-ю заполнения строк

            Console.WriteLine("\nИзначальный массив:");
            WriteArr(arr);                                             //Функ-я вывода

           int[] minRow = arr[0];                                    //Ставим поумолчанию мин строку массива
           int[] maxRow = arr[0];                                   //Ставим поумолчанию макс строку массива

           minRow = FunArr_Min(arr, minRow);                      //Переходим в функ-ю для нахождения мин. строки
           maxRow = FunArr_Max(arr, maxRow);                     //Переходим в функ-ю для нахождения макс. строки
           arr = ModifFunArr(arr, minRow, maxRow, a);           //Переходим в функ-ю модернизации рванного массива

           System.Console.WriteLine("Измененный массив:");
           WriteArr(arr);                                   //Функ-я вывода


           System.Console.ReadKey();
        }
    }
}
