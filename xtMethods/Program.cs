/*
<Access Modifiers> <return type> <name_method>(<parameters>)
{
    // Các câu lệnh trong phương thức
}
Access Modifiers cho biết cấp độ được phép truy cập đến hàm này (nói kỹ thi học về hướng đối tượng), có các mức độ như public, private,
protect, internal ... Nếu thiếu thành phần này thì mặc định coi là internal (truy cập được ở các file cùng assembly cùng file code).
Ngoài ra đếu cho vào từ khóa static ở trước Access Modifiers thì phương thức (hàm) đó gọi là PHƯƠNG THỨC TĨNH (Truy cập được mà không cần
tạo đối tượng lớp), thường dùng kèm với Access Modify tên public để tạo các hàm chức năng, tiện ích.

return type là kiểu trả về của hàm như int, double, string ... nếu hàm không có kiểu trả về thì đề từ khóa void.

name_method tên của phương thức do bạn đặt.
parameters là các tham số của hàm nếu có, các tham số khai báo theo mẫu kiểu tên như int thamso1, nhiều tham số thì cách nhau bởi dấu ,.
Cuối cùng là phần thân hàm { }, trong đó chứa các câu lệnh C# mà khi hàm được gọi nó sẽ thi hành theo logic của code từ đấu đến cuối, hoặc khi gặp lệnh return;. Khi hàm có kiểu trả về thì trong thân hàm bắt buộc phải có câu lệnh return value; (với value là giá trị, đối tượng, biểu thức có kiểu cùng kiểu tra về của hàm)
*/
using Abc;

internal class Program
{
    class Count
    {
        public int c = 1;
    }

    public static int tich(int a, int b)
    {
        int result;
        result = a * b;
        return result;
    }

    static void XinChao(string ten, string ho)
    {
        string fullName;
        fullName = ho + " " + ten;
        Console.WriteLine($"Xin chao {fullName}");
    }

    static void binhPhuong(int x, out int kq)
    {
        kq = x * x;
    }

    private static void Main(string[] args)
    {
        /*
        // Cách khác
        int x = 234;
        int y = 456;
        var result = Tinhtoan.tong(x, y);
        // var result = Tinhtoan.tong(123, 456);
        Console.WriteLine(result);

        int ketQua;
        // XinChao("A", "Nguyen");
        XinChao(ho: "Pham Van", ten: "B");

        ketQua = tich(3, 4);
        Console.WriteLine(ketQua);

        //Quá tải phương thức
        float a = 12.12f;
        float b = 10.0f;

        var result1 = Tinhtoan.tong(a, b);
        Console.WriteLine(result1);

        int a1;
        binhPhuong(4, out a1);
        Console.WriteLine(a1);
        */

        Count count = new Count();
        Console.WriteLine(count.c);

        dem(count);
        Console.WriteLine(count.c);
    }

    static void dem(Count count)
    {
        count.c++;
    }
}
