int CountVowel (string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i][0] == 'a' || array[i][0] == 'e' 
        || array[i][0] == 'i' || array[i][0] == 'o' 
        || array[i][0] == 'u' || array[i][0] == 'y')
        {
            count++;
        }
    }

    return count;
}

string[] words = {"asd", "wad", "efg", "qwe"};
Console.Write(CountVowel(words));
