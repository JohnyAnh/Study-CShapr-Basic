/*
What is the conditional operator?
The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on
whether the Boolean expression evaluates to true or false. The conditional operator is commonly referred
to as the ternary conditional operator.
Ex:
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>
*/

int saleAmount = 1001;

// int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
