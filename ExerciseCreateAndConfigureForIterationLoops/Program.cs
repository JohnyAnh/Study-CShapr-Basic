Console.WriteLine("----------Write a basic for statement---------");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("--------Change the iteration conditions--------------");

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("--------Experiment with the iterator's pattern-------------");

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
Console.WriteLine("----------Use the break keyword to break the iteration statement------------");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7)
        break;
}
Console.WriteLine("---------Loop through each element of an array-------------");
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine("---------Examine the limitation of the foreach statement----------");

/*
string[] names1 = { "Alex", "Eddie", "David", "Michael" };
foreach (var name1 in names1)
{
    // Can't do this:
    if (name1 == "David")
        name1 = "Sammy";
}
*/

/*
If you attempt to compile and run this code, you will see an exception.

Output
Cannot assign to name because it is a 'foreach iteration variable'

In other words, you can't reassign the value of name because it is part of the foreach iteration's inner implementation.
*/
Console.WriteLine(
    "-------Overcoming the limitation of the foreach statement using the for statement-------------"
);
string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names2.Length; i++)
    if (names2[i] == "David")
        names2[i] = "Sammy";

foreach (var name2 in names2)
    Console.WriteLine(name2);
