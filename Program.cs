//В двумерном массиве заменить элементы, у которого оба индекса четные на их квадраты
void FillArray(int[,] matrix)
{
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0; j< matrix.GetLength(1);j++)
        {
            matrix[i,j]=new Random().Next(-5,5);
        }
    }
}
//-------------------------заданна матрица числа взяты на промежутке(-5,5)
void PrintArray(int[,] matrix)
{
for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0; j< matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j]+ " " );
        }
        Console.WriteLine();
    }
}
//---------------------------печать в консоле массива
void Search( int [,] matrix)
{
    int chech=0;
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j=0; j< matrix.GetLength(1);j++)
        {
            if ((i+1)%2==0 && (j+1)%2==0) matrix[i,j]=matrix [i,j]*matrix[i,j];
            
        chech+=1;
        }


}
}
//------------------------поиск четных чисел массива и возведение в квадрат
Console.WriteLine("введите число строк m");
int m = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("введите число столбцов n");
int n = int.Parse(Console.ReadLine()??"0");
int[,]matrix=new int[m,n];
//------------------------------------------------
FillArray(matrix);
Console.WriteLine("начальная матрица");
Console.WriteLine();
PrintArray(matrix);
Search(matrix);
Console.WriteLine("измененная матрица");
PrintArray(matrix);