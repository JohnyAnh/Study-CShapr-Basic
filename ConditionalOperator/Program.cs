/*
What is the conditional operator?
The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on
whether the Boolean expression evaluates to true or false. The conditional operator is commonly referred
to as the ternary conditional operator.
Ex:
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
*/

int saleAmount = 1001;

// int discount = saleAmount > 1000 ? 100 : 50; Delete
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
Console.WriteLine("-------------------------------------------------------------------");

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
// Random random = new Random();
// int aCoinFlip = random.Next(0, 2);
// Console.WriteLine($"{(aCoinFlip == 1 ? "Face Up" : "Face down")}");
// Console.WriteLine("\n");

//Version 2
/*
This code is merely "one possible solution". You could have eliminated the temporary variable
flip by calling the Next() inside of the Boolean expression like so:
*/
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "Face Up" : "Face down");
Console.WriteLine("-------------------------------------------------------------------");

/*
In this challenge, you'll implement decision logic based on a series of business rules. The business rules specify
the access that will be granted to users based on their role-based permissions and their career level. Code branches
will display a different message to the user depending on their permissions and level.

 Important

You will need to use the Contains() helper method to determine whether the value assigned to the permission string
contains one of the permission values specified by the "business rules". For example,
the expression permission.Contains("Admin") will return true when using the initial data values specified in the code above.

Here are the Business Rules that your solution must satisfy:

If the user is an Admin with a level greater than 55, output the message:

Output

Copy
Welcome, Super Admin user.
If the user is an Admin with a level less than or equal to 55, output the message:

Output

Copy
Welcome, Admin user.
If the user is a Manager with a level 20 or greater, output the message:

Output

Copy
Contact an Admin for access.
If the user is a Manager with a level less than 20, output the message:

Output

Copy
You do not have sufficient privileges.
If the user is not an Admin or a Manager, output the message:

Output

Copy
You do not have sufficient privileges.
*/

string permission = "Admin|Manager";
int level = 55;
if (permission.Contains("Admin"))
{
    if (level > 55)
        Console.WriteLine("Welcome, Super Admin user.");
    else
        Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access.");
    else
        Console.WriteLine("You do not have sufficient privileges.");
}
else
    Console.WriteLine("You do not have sufficient privileges.");
