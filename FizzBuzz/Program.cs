var fbb = new Dictionary<int, string>(){
    {3, "Fizz"},
    {13, "Fezz"},
    {5, "Buzz"},
    {7, "Bang"},
    {11, "Bong"},
};

for (var counter = 1; counter <0; counter++)
{
    string[] wordArray =[];
    foreach(KeyValuePair<int, string> entry in fbb) {
        if (counter % entry.Key == 0) 
        {
            wordArray = [.. wordArray, entry.Value];
        }
    }
    if (wordArray.Length ==0)
    {
        Console.WriteLine(counter);
    }
    else if (wordArray.Contains("Bong") && wordArray.Contains("Fezz"))
    {
        Console.WriteLine("FezzBong");
    }
    else if (wordArray.Contains("Bong"))
    {
        Console.WriteLine("Bong");
    }
    else if (counter % 17 == 0) {
        Array.Reverse(wordArray);
        Console.WriteLine(String.Join("",wordArray));
    }
    else
    {
        Console.WriteLine(String.Join("",wordArray));
    }
}
