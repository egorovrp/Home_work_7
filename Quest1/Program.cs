// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
double[,] array = GetArray(rows, columns);
PrintArray(array);

int GetNum(string message)
{
	Console.Write(message);
	int num = int.Parse(Console.ReadLine()!);
	return num;
}

double[,] GetArray(int row, int colum)
{
	double[,]res = new double[row, colum];
	for(int i=0; i<row; i++)
	{	
		for(int j=0; j< colum ; j++)
		{
			res[i,j] = Math.Round(new Random().NextDouble()*10,1);
			
		}
	}
	return res;
}

void PrintArray(double[,]arr)
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
	