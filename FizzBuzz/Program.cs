var fbb = new Dictionary<int, string>(){
    {3, "Fizz"},
    {13, "Fezz"},
    {5, "Buzz"},
    {7, "Bang"},
    {11, "Bong"}
};

for (var counter = 1; counter <144; counter++)
{
    var word = "";
    foreach(KeyValuePair<int, string> entry in fbb) {
        if (counter % entry.Key == 0) 
        {
            word += entry.Value;
        }
    }
    if (word =="")
    {
        Console.WriteLine(counter);
    }
    else if (word.Contains("Bong") && word.Contains("Fezz"))
    {
        Console.WriteLine("FezzBong");
    }
    else if (word.Contains("Bong"))
    {
        Console.WriteLine("Bong");
    }
    else
    {
        Console.WriteLine(word);
    }
}
