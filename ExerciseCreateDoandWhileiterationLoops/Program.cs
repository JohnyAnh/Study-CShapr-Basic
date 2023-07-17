/*
Here are the rules for the battle game that you need to implement in your code project:

You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner.

Output

Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/
Random dice = new Random(); // Tạo đối tượng Random để sinh số ngẫu nhiên
int hero = 10; // Khởi tạo giá trị ban đầu cho máu của anh hùng là 10
int monster = 10; // Khởi tạo giá trị ban đầu cho máu của quái vật là 10

do
{
    int roll = dice.Next(1, 11); // Lắc xúc xắc và lấy một số ngẫu nhiên từ 1 đến 10
    monster -= roll; // Trừ số ngẫu nhiên từ máu của quái vật
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0)
        continue; // Nếu máu của quái vật nhỏ hơn hoặc bằng 0, tiếp tục vòng lặp mà không thực hiện các dòng code bên dưới

    roll = dice.Next(1, 11); // Lắc xúc xắc và lấy một số ngẫu nhiên từ 1 đến 10
    hero -= roll; // Trừ số ngẫu nhiên từ máu của anh hùng
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");
} while (hero > 0 && monster > 0); // Lặp lại vòng lặp do-while khi cả anh hùng và quái vật còn máu

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!"); // In ra thông báo người chiến thắng dựa trên máu cuối cùng của anh hùng và quái vật
