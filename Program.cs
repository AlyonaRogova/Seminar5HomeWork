using System;

namespace Seminar5HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // Задайте массив, заполненный случайными трехзначными числами. 
            // //Напишите программу, которая покажет количество четных чисел в массиве.
            // int [] CreateArray (int size, int min, int max){
            //     int [] array = new int [size];
            //         for (int i=0; i<size; i++){
            //             array [i] = new Random().Next(min, max+1);
            //         }
            //     return array;
            // }

            // void ShowArray (int[] array){
            //     for (int i = 0; i<array.Length; i++){
            //         Console.Write($"{array[i]} ");
            //     }
            // }

            // int CountNum (int [] array){
            //     int count = 0;
            //     for (int i = 0; i< array.Length; i++){
            //         if (array [i] % 2 == 0) count++;
            //     }
            //     return count;
            // }

            // Console.WriteLine ("Введите два числа от 100 до 999: ");
            // int min = Convert.ToInt32(Console.ReadLine());
            // int max = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine ("Введите количество элементов: ");
            // int size = Convert.ToInt32(Console.ReadLine());
            
            // int [] array = CreateArray(size,min,max);
            // ShowArray (array);

            // int result = CountNum (array);
            // Console.WriteLine();
            // Console.WriteLine ($"Количество четных чисел в массиве:" + result);

            //Задайте одномерный массив, заполненный случайными числами. 
            //Найдите сумму элементов, стоящих на нечетных позициях.
            
            int [] CreateArray (int size, int min, int max){
                int [] array = new int [size];
                    for (int i=0; i<size; i++){
                        array [i] = new Random().Next(min, max+1);
                    }
                return array;
            }

            void ShowArray (int[] array){
                for (int i = 0; i<array.Length; i++){
                    Console.Write($"{array[i]} ");
                }
            }

            int PlaceSum (int [] array){
                int res = 0;
                for (int i = 0; i < array.Length; i++){
                    if (i % 2 == 0) res+= array[i];
                }
                return res;
            }

            Console.WriteLine ("Введите два числа: ");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Введите количество элементов: ");
            int size = Convert.ToInt32(Console.ReadLine());
            
            int [] array = CreateArray(size,min,max);
            ShowArray (array);

            int result = PlaceSum (array);
            Console.WriteLine();
            Console.WriteLine ($"Сумма элементов, находящихся на нечетных позициях:" + result);


           
        }
    }
}
