/*
Notice that there are two main problems with these comments:

The code comments unnecessarily explain the obvious functionality of individual lines of code. These are considered 
low-quality comments because they merely explain how C# or methods of the .NET Class Library work. 
If the reader is unfamiliar with these ideas, they can look them up using learn.microsoft.com or IntelliSense.

The code comments don't provide any context to the problem being solved by the code. These are considered low-quality 
comments because the reader doesn't gain any insight into the purpose of this code, especially as it relates to the 
larger system.
*/


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}