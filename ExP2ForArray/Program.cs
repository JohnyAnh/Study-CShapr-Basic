String[] Arr = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach (String item in Arr)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine($"The name starts with {item}!");
    }
}