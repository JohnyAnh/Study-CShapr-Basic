/*
What is whitespace?
The term "whitespace" refers to individual spaces produced by the space bar, tabs produced by the tab key, 
and new lines produced by the enter key.

The C# compiler ignores whitespace. To understand how whitespace is ignored, and how to maximize clarity using white space, 
work through the following exercise.
*/

// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);
// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//     if ((roll1 == roll2) && (roll2 == roll3)) {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6; 
//     } else {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}


/*
The main takeaways from this exercise:

Use whitespace judiciously to improve the readability of your code.
Use line feeds to create empty lines to separate phrases of code. A phrase includes lines of code that are similar, or work together.
Use line feeds to separate code block symbols so that they are on their own line of code.
Use the tab key to line up a code block with the keyword they're associated with.
Indent code inside of a code block to show ownership.
*/