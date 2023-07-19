//Thư viện sử dụng hỗ trợ mảng mở rộng có thêm phương thức
using System.Linq;

// string sinhVien1 = "Nguyen Van A";
// string sinhVien2 = "Nguyen Van B";
// string sinhVien3 = "Nguyen Van C";

// Console.WriteLine(sinhVien1);
// Console.WriteLine(sinhVien2);
// Console.WriteLine(sinhVien3);
/*
string[] ds = new string[3];
ds[0] = "Nguyen van A";
ds[1] = "Nguyen van B";
ds[2] = "Nguyen van C";

for (int i = 0; i <= 2; i++)
{
    Console.WriteLine(ds[i]);
}

*/
/* Cách khai báo
int[] mangSoNguyen;
string[] mang1 = new string[2] { "Dien thoai", "May tinh" };
double[] mang2 = { 0.1, 0.3, 0.9, 20 };

mangSoNguyen = new int[3] { 1, 2, 0 };
*/
/* Cách sử dụng for foreach linq
int[] numbers = { 1, 3, 4, 7, 5, 34, 7 };
int soPhanTu = numbers.Length;

// for (int i = 0; i < soPhanTu; i++)
// {
//     Console.WriteLine(numbers[i]);
// }

// foreach (var item in numbers)
// {
//     Console.WriteLine(item);
// }
Console.WriteLine($"So phan tu: {numbers.Length}");
Console.WriteLine($"Chieu: {numbers.Rank}");
Console.WriteLine($"Lay gia tri nho nhat: {numbers.Min()}");
Console.WriteLine($"Lay gia tri lon nhat: {numbers.Max()}");
Console.WriteLine($"Tong gia tri cac phan tu: {numbers.Sum()}");

Array.Sort(numbers);
foreach (var item in numbers)
{
    Console.Write(item);
}
*/

/*
        0   1   2
    0   2   3   4.5
    1   1   9   8

    [0,1] = 3
    [1,2] = 8
*/

double[,] numbers = new double[2, 3]
{
    { 2, 3, 4.5 },
    { 1, 9, 8 }
};
Console.WriteLine(numbers[0, 2]);

//Cách duyệt qua tất cả các phần tử của vòng lặp 2 chiều
int hang = 2;
int cot = 3;

for (int i = 0; i < hang; i++)
{
    for (var j = 0; j < cot; j++)
    {
        Console.Write(numbers[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
