// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// roll1 = 6;
// roll2 = 6;
// roll3 = 6;

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win win a new car!");
// }
// else if( total >= 10)
// {
//     Console.WriteLine("You win a new laptop");
// }
// else if( total == 7)
// {
//     Console.WriteLine("You win a new laptop");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }


// Console.WriteLine("Total roll: " + total);

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
if (daysUntilExpiration > 5 && daysUntilExpiration <= 10)
{
    Console.WriteLine($" Your subscription is {daysUntilExpiration} day!");
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration > 1 && daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration == 1 )
{
    discountPercentage = 20;
    Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration < 1)
{
    Console.WriteLine("Your subscription has expired.");
}
else
{
    Console.WriteLine($" Your subscription is {daysUntilExpiration} day!");
}

