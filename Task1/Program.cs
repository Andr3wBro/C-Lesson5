// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateAndFillArr(int large, int min, int max)
{
    int[] array = new int[large];
    for (int ifill = 0; ifill < array.Length; ifill++)
    {
        array[ifill] = new Random().Next(min, max + 1);
    }
    return array;
}
void printArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
    System.Console.WriteLine();
}

int SearchEvenNumbers(int[] arr)
{
    int count = 0;
    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i]%2 == 0)
        {
            count++;
        }
    }
System.Console.WriteLine($"Even numbers in array => {count}");
return count;
}


int[] myArray = CreateAndFillArr(10,100,1000);
printArr(myArray);
SearchEvenNumbers(myArray);
