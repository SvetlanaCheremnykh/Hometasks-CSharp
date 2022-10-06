/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

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
int[,] generateSquare(int height, int width, int[,] ishDArray)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)  
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
               twoDArray[i,j] = ishDArray[i,j]*ishDArray[i,j]; 
            }
            else 
            {
               twoDArray[i,j] = ishDArray[i,j];
            }
        } 
    }
    return twoDArray; 
}
int[,] generateArray = generate2DArray(3,4,1,10);
print2DArray(generateArray);

Console.WriteLine();

int[,] updatedArray = generateSquare(3,4, generateArray);
print2DArray(updatedArray);