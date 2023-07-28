// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();
int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
Metod(array);

int GetNum(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

int[,] GetArray(int row, int colum)
{
	int[,]res = new int[row, colum];
	for(int i=0; i<row; i++)
	{	
		for(int j=0; j< colum ; j++)
		{
			res[i,j] = new Random().Next(0,100);
		}
	}
	return res;
}

void PrintArray(int[,]arr)
{
	for(int i=0; i<arr.GetLength(0); i++) //arr.GetLength(0) строки
	{	
		for(int j=0; j<arr.GetLength(1); j++) //arr.GetLength(1) столбцы
		{
			Console.Write($"{arr[i, j]} ");
		}
		Console.WriteLine();
	}
}

void Metod(int [,] arr)
{
   int x = GetNum("Введите индекс строки элемента в двумерном массиве: ");
   int y = GetNum("Введите индекс столбца элемента в двумерном массиве: ");
    if (x<array.GetLength(0))
    {
        if (y<array.GetLength(1))
        {
        Console.Write($"Элемент массива: {array[x-1,y-1]}");
        } 
        else
        {
        Console.Write("Такого числа нет!");
        }   
    }
    else
    {
    Console.Write("Неверно введены данные!");   
    }
}
