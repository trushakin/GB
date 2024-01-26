﻿// Задайте двумерный массив. Найдите элементы, у которых оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4
// Обсудить этапы решения задачи
// Оформить этапы в виде функций
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4


// int[,] array = new int[3,4];
// void CreateArray()      // Функция заполняет массив 
// {
// for (int i= 0; i < array.GetLength(0); i ++)
//     {
//         for (int j= 0; j < array.GetLength(1); j ++)
//         {
//             array[i,j] = new Random().Next(1,10);
           
//         } 
   
//     }
// }

// void PrintArray() // Функция выводит массив 
// {
// for (int i= 0; i < array.GetLength(0); i ++)
//     {
//         for (int j= 0; j < array.GetLength(1); j ++)
//         {
//            System.Console.Write(array[i,j]+ " ");
//         } 
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// void FindElementsArray() // Функция меняет массив 
// {
// for (int i= 0; i < array.GetLength(0); i ++)
//     {
//         for (int j= 0; j < array.GetLength(1); j ++)
//         {
//            if (i %2 ==0 && j %2==0 )
//            {
//                 array[i,j]= array[i,j]*array[i,j];
//            };
//         } 
  
//     }
// }

// CreateArray();
// PrintArray();
// FindElementsArray();
// PrintArray();



// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и
// т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4


// 



int[,] array = new int[3,4];
double[] array2 = new double[array.GetLength(0)];

void CreateArray()      // Функция заполняет массив 
{
    for (int i= 0; i < array.GetLength(0); i ++)
    {
        for (int j= 0; j < array.GetLength(1); j ++)
        {
            array[i,j] = new Random().Next(1,10);
           
        } 
   
    }
}

void PrintArray() // Функция выводит массив 
{
    for (int i= 0; i < array.GetLength(0); i ++)
    {
        for (int j= 0; j < array.GetLength(1); j ++)
        {
           System.Console.Write(array[i,j]+ " ");
        } 
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void FindElementsArray() // Функция меняет массив 
{
    

    for (int i= 0; i < array.GetLength(0); i ++)
    {
        double sumElement=0;

        for (int j= 0; j < array.GetLength(1); j ++)
        {
           
              sumElement+=array[i,j];
            //    sumElement = sumElement + array[i,j]; это полная запись, аналогична верхней 
           
        } 
    array2[i] = sumElement/array.GetLength(1);
    }
 }

 void PrintArray2() // Функция выводит массив 
{
    for (int i= 0; i < array2.Length; i ++)
    {
       
        System.Console.Write(array2[i]+ " ");
    }
    System.Console.WriteLine();
}



CreateArray();
PrintArray();
FindElementsArray();
PrintArray2();