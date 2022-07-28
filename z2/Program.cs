string[] ConcatinationArray(string[] array)
{
    string[] ConcArray = new string[array.Length];

    for(int i = 0; i < array.Length; i = i + 2)
    {
        ConcArray[i] = array[i] + array[i+1];
    }

    return ConcArray;
}

void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] words = {"asd", "wad", "efg", "qwe", "dfg", "ret", "ops", "vbn"};
ShowStringArray((ConcatinationArray(words)));
