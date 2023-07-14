/*
What is the conditional operator?
The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on
whether the Boolean expression evaluates to true or false. The conditional operator is commonly referred
to as the ternary conditional operator.
Ex:
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
*/

// int saleAmount = 1001;

// int discount = saleAmount > 1000 ? 100 : 50; Delete
// Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

/*
Here are your challenge requirements:

1. Ensure that you have an empty Program.cs file open in Visual Studio Code.

If necessary, open Visual Studio Code, and then complete the following steps to prepare a Program.cs file in the Editor:

2. Use the Random class to generate a value.

3. Consider the range of numbers that is required.

3. Based on the value generated, use the conditional operator to display either heads or tails.

There should be a 50% chance that the result is either heads or tails.

4. Your code should be easy to read, but with as few lines as possible.

You should be able to accomplish the desired result in three lines of code.
*/
//Version 1
Random random = new Random();
int aCoinFlip = random.Next(0, 2);
Console.WriteLine($"{(aCoinFlip == 1 ? "Face Up" : "Face down")}");
Console.WriteLine("\n");

//Version 2
/*
This code is merely "one possible solution". You could have eliminated the temporary variable
flip by calling the Next() inside of the Boolean expression like so:
*/
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "Face Up" : "Face down");
