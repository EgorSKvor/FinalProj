
# Входные данные
string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
### Указываем макс длину элемента 
int MaxWordLength = 3;
### Создаем основной метод для проверки длины элемента в массиве, который возваращет полученный массив
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
### Описываем метод для вывода массива
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
### Создаем третий метод для красивого вывода какой был входной массив и какой получился
void PrintTask(string[] array)
{
    System.Console.WriteLine("Source array: ");
    #### вызываем метод вывода
    PrintArray(array); 
    #### записываем в новую переменную основной метод, вызвав его
    string[] shortArray = GetWordsArray(array);
    System.Console.WriteLine($"Result array (words are less or equal than {MaxWordLength} symbols)");
    PrintArray(shortArray);
    System.Console.WriteLine();
}
PrintTask(arr1);
PrintTask(arr2);
PrintTask(arr3);