// delegate (type) biến đc gán bằng phương thức, khai báo ở trong namespace hoặc trong class
namespace Delegate
{
    //1. Khai báo giống như method thông thường thêm từ khóa delegate thêm kiểu trả về
    public delegate void Showlog(string message);

    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        /*
        //Ví dụ Delegate Func
                static int Tong(int a, int b) => a + b;
        
                static int Hieu(int a, int b) => a - b;
        */


        // Sử dung delegate trong tham số phương thức
        static void Tong(int a, int b, Showlog log)
        {
            int kq = a + b;
            log?.Invoke($"Tổng là {kq}");
        }

        public static void Main(string[] args)
        {
            //Delegate trong C#
            //Action, FunC: delegate - gereric

            //Delegate Func trong C# xác định kiểu trả về kiểu trả về được xác định ở cuối cùng. Nếu có các tham số thì tham số được liệt kê ở phía trước.
            //Func<int> f1; //~delegate int KIEU()
            //Func<string, double, string> f2; //~delegate string KIEU(string s, double s);

            /*
            //Ví dụ Delegate Func
            Func<int, int, int> tinhToan; //~delegate int KIEU(int a, int b);
            int a = 5,
                b = 10;
            tinhToan = Tong;
            Console.WriteLine($"Tong la: {tinhToan(a, b)}");
            */

            // Sử dung delegate trong tham số phương thức
            Tong(4, 5, Info); // In ra màu xanh
            Tong(4, 5, Warning); // In ra màu đỏ

            /* Nhiều phương thức(chuỗi phương thức)
            Showlog log = null; //+=

            //Dùng += để gọi các phương thức với delegate gọi bao lần hiện bấy nhiêu lần
            log += Info;
            log += Info;
            log += Info;

            log += Warning;

            log?.Invoke("Xin chao");
            */
            /*
            Showlog log = null;
            log = Info;
            //Kiểm tra biến log khác null
            if (log != null)
                log("Xin Chao");

            log?.Invoke("Xin chao Abc"); //Cách viết giống dùng if

            log = Warning;
            log("Hoc ve delegate");
            
            */

            /*
            //Cách 1 thi hành các biến đang lưu trong delagate
            log = Info;
            log("Xin Chao");
            //Cách 2 thi hành các biến đang lưu trong delagate
            log.Invoke("Xin chào Abc");
            */
        }
    }
}
