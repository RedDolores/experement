

int[,] GetRandomTwoDimensionalArray(int n, int m)
{
    Random x = new Random();
    int[,] array = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = x.Next(1, 10);
        }
    }
    return array;
}

int[] SelectLineOfTwoDimensionalArray(int[,] arr, int i)
{
    int[] array = new int[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        array[j] = arr[i, j];
    }
    return array;
}

void SortingArray(int[] array)
{
    int tmp = 0;
    int n = array.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        for (int j = n - 1; j > i; j--)
        {
            if (array[i] < array[j])
            {
                tmp = array[i];
                array[i] = array[j];
                array[j] = tmp;
            }
        }
    }
    // return array;
}

Console.Write("введите количество строк массива: ");
int numberColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("введите количество столбцов массива: ");
int numberRows = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = GetRandomTwoDimensionalArray(numberColumns, numberRows);


for (int i = 0; i < randomArray.GetLength(0); i++)
{
    int[] lineOfArray = SelectLineOfTwoDimensionalArray(randomArray, i);
    SortingArray(lineOfArray);
    Console.Write(lineOfArray[i]);

}






// Console.WriteLine(string.Join(", ", sortMass(mass)));




