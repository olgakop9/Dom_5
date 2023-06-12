﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Console.WriteLine("Введите размер массива");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//FillArrayRandomNumbers(numbers);
//Console.WriteLine("Заданный массив: ");
//PrintArray(numbers);
//int count = 0;

//for (int z = 0; z < numbers.Length; z++)
//    if (numbers[z] % 2 == 0)
//        count++;

//Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

//void FillArrayRandomNumbers(int[] numbers)
//{
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        numbers[i] = new Random().Next(100, 1000);
//    }
//}
//void PrintArray(int[] numbers)
//{
//    Console.Write("[ ");
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//    Console.Write("]");
//    Console.WriteLine();
//}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

//using System;
//using System.Linq;

//namespace TestApp
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var rnd = new Random();
//            var arr = new int[1];

//            for (int i = 0; i < arr.Length; i++)
//                Console.Write("{0}\t", arr[i] = rnd.Next(-100, 100));
//            Console.WriteLine();

//            var even = arr.Where((element, index) => index % 2 != 0);
//            var odd = arr.Where((element, index) => index % 2 == 0);

//            Console.WriteLine("Чётные. Количество: {0}. Сумма: {1}.", even.Count(), even.Sum());
//            Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());

//            Console.ReadKey();
//        }
//    }
//}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

//Console.WriteLine("Введите размер массива:");
//int n = Convert.ToInt32(Console.ReadLine()); // Задаём размер массива
//int [] mass  = new int[n];      // Создаём массив
//Random rnd = new Random();      // Создание объекта для генерации чисел
//for (int i = 0; i < n; i++)
//    { mass[i] = rnd.Next(-50, 50);  // Заполнение рандомами
//    Console.Write($" {mass[i]} ");
//}
//int min = 0;
//int max = 0;
//foreach (int i in mass)  // Поиск максимального и минимального значения
//{
//    if (min > i) min = i;
//    if (max < i) max = i;
//}
//Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
//Console.WriteLine($"Разница между максимальным и минимальным элементом: {max-min}");