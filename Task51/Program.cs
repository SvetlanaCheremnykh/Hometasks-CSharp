​/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
int[,] generate2DArray(int height, int width, int min, int max)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)  
        {
            twoDArray [i,j] = new Random().Next(min, max+1);
        } 
    }
    return twoDArray; 
}
void print2DArray(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int sumMainDiagonal(int height, int width, int[,] ishDArray)
{
    int sum = 0;
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)  
        {
            if (i == j);
            {
               sum += ishDArray[i,j]; 
            }
         } 
    }
    return sum; 
}
int[,] generateArray = generate2DArray(3,4,1,10);
print2DArray(generateArray);

Console.WriteLine();

int[,] updatedArray = generateSquare(3,4, generateArray);
print2DArray(updatedArray);
