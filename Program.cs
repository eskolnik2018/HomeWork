// Задача 1: Задайте одномерный массив из 10 целых чисел
//  от 1 до 100. Найдите количество элементов массива,
//   значения которых лежат в отрезке [20,90].

// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество
//  чётных чисел в массиве.

// Задача 3: Задайте массив из вещественных чисел с ненулевой
// дробной частью. Найдите разницу между максимальным и
//  минимальным элементов массива.

// Задача 4**(не обязательно): Дано натуральное число в диапазоне 
// от 1 до 100 000. Создайте массив, состоящий из цифр этого числа.
//  Старший разряд числа должен располагаться на 0-м индексе массива,
//   младший – на последнем. Размер массива должен быть равен
//    количеству цифр.



// // Задача 1

// int size = 10;
// int[] array = new int[size];
// int count = 0;

// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(1, 101);
//     if (array[i] >= 20 && array[i] <= 90) count++;
// }

// Console.WriteLine($"Массив ДО: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Количество чисел в диапазоне от 20 до 90 = {count}");



// // Задача 2

// int size = 10;
// int[] array = new int[size];
// int count = 0;

// for (int i = 0; i < array.Length; i++) // array.Length = size
// {
//     array[i] = new Random().Next(1, 101);
//     if (array[i] %2 ==0) count++;
// }

// Console.WriteLine($"Массив ДО: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Количество четных чисел в массиве = {count}");



// // Задача 3 

// double[] arr = new double[10];
// double minNumber = 1000.0;
// double maxNumber = 0.0;

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001), 2);
//     if (arr[i] > maxNumber) maxNumber = arr[i];
//     if (arr[i] < minNumber) minNumber = arr[i];
// }

// Console.WriteLine($"Результат заполнения массива: [ {string.Join("; ", arr)} ]");
// Console.WriteLine($"Максимум {maxNumber} - минимум {minNumber} = разница {maxNumber - minNumber}");



// Задача 4

int generatedNumber = new Random().Next(1, 100001);
int temp = generatedNumber;
int count = 0;

while (generatedNumber > 0)
{
    generatedNumber /= 10;
    count++;
}
Console.WriteLine($"В заданом числе {temp} количество разрядов {count}");

int[] arrDigits = new int[count];

for (int i = arrDigits.Length - 1; i >= 0; i--)
{
    arrDigits[i] = temp % 10;
    temp /= 10;
}
Console.WriteLine($"Результат: [ {string.Join("; ", arrDigits)} ]");