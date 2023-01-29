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

