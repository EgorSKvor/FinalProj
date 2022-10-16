//Задача: Написать программу, которая из имеющегося массива строк формирует новый 
//массив из строк,длина которых меньше, либо равна 3 символам. Первоначальный массив 
//можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями,лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};

int MaxWordLength = 3;
string[] GetWordsArray(string[]array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MaxWordLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

{

void PrintArray(string[] array)
{
    if(array.Length == 0)
    {
        System.Console.WriteLine("Array is empty");
    }
    else
    {
        Array.ForEach(array, (str) => System.Console.WriteLine($"{str}"));
        System.Console.WriteLine();
    }
}

