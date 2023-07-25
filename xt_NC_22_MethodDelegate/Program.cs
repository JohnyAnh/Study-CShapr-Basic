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

        public static void Main(string[] args)
        {
            // Nhiều phương thức(chuỗi phương thức)
            Showlog log = null; //+=

            //Dùng += để gọi các phương thức với delegate gọi bao lần hiện bấy nhiêu lần
            log += Info;
            log += Info;
            log += Info;

            log += Warning;

            log?.Invoke("Xin chao");

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
