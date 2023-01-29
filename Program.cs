string[] arr1 = {"hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
	
int maxsymbol = 3;

string[] GetNewArray(string[] array)
{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
			
	for (int i = 0; i < length; i++)
	{
	    if(array[i].Length <= maxsymbol)
		{
		    result[count] = array[i];
		    count++;
		}
	}	
    Array.Resize(ref result, count);		
    return result;
}

void PrintArray(string[] array)
{
    if(array.Length == 0)
	{
		Console.WriteLine("Подходящие элементы массива отсутствуют!");
	}
    else
	{
        Array.ForEach(array, (str) => Console.Write($"[{str}] "));
        Console.WriteLine();
    }
}

void PrintOurWork(string[] array)
{
    Console.WriteLine("Исходный массив: ");
	PrintArray(array);
	string[] shortArray = GetNewArray(array);
	Console.WriteLine($"Новый массив (элементы состоящие из {maxsymbol} и менее символов):");
	PrintArray(shortArray);
	Console.WriteLine();
}
		
PrintOurWork(arr1);
PrintOurWork(arr2);
PrintOurWork(arr3);