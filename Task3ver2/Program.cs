// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Если пытаюсь в double в функции CreateArray попробовать задать длинну, выдает ошибку, что у него не получается double в int. Получилось только так.
double[] CreateArray()
{
double[] array = new double[20];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
return array;
}
void printArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    System.Console.WriteLine();
}

void FindDiferenceBetweenMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double diference = 0;
    for (var i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    diference = max - min;
    System.Console.WriteLine($" Max is {max} ,  Min is {min} , diference betwen max and min =  , {diference}");
}

double[] myArray = CreateArray();
printArr(myArray);
FindDiferenceBetweenMinMax(myArray);
