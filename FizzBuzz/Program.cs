var fbb = new Dictionary<int, string>(){
    {3, "Fizz"},
    {5, "Buzz"},
    {7, "Bang"}
};

for (var counter = 1; counter <101; counter++)
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
    else
    {
        Console.WriteLine(word);
    }
}
