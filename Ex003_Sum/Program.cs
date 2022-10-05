// Написать программу сложения 2х чисел на языке С# на Windows. Уточнить, откуда берутся числа, куда выводить или сохранять сумму, с какими числами работаем (целые, положительные)
// Написать алгоритм
int numberA = 31;
int numberB = 5;
int rezult = numberA + numberB;
Console.WriteLine(rezult);

// Если взять случайные (рандомные числа)
int numberA = new Random().Next(1,10); // числа от 1 до 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,15); // числа от 1 до 14
Console.WriteLine(numberB);
int rezult = numberA + numberB;
Console.WriteLine(rezult);
