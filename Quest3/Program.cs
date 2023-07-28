// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Clear();
int rows = GetNum("Введите количество строк: ");
int columns = GetNum("Введите количество столбцов: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
double[] aver = AverageNum(array);
PrintArrayAverage(aver);

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

void PrintArrayAverage(double[]arr)
{
	for(int i=0; i<arr.Length; i++) 
	{	
     	Console.WriteLine($"Среднее арифметическое {i+1} столбца: {Math.Round((arr[i]),1)}");
	}
		
}


double[] AverageNum(int[,]arr)
{   
        double[] average = new double[arr.GetLength(1)];
        for(int j=0; j< arr.GetLength(1); j++)
        {
            for(int i=0; i< arr.GetLength(0); i++)
            {
                average[j] = average[j] + arr[i,j];
            }
        }
    for(int j=0; j< average.Length; j++)
    {
        average[j]=average[j]/arr.GetLength(0);
    }
    return average;
}