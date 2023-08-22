namespace CS_Lambda
{
    class Program
    {
        /*
        Biểu thức lambda còn gọi là biểu thức hàm nặc danh (Anonymous),
        một biểu thức khai báo giống phương thức (hàm) nhưng thiếu tên.
        Cú pháp để khai báo biểu thức lambda là sử dụng toán dử:
        C1
        (các_tham_số) => biểu_thức;

        C2
        (các_tham_số) =>
            {
            // các câu lệnh
                // Sử dụng return nếu có giá trị trả về
            }
        */
        public static void Main(string[] args)
        {
            /*C1
            Action<string> thongbao;
            thongbao = (string s) => Console.WriteLine(s); //~ delegate void KIEU(string s) = Action<string>
            thongbao?.Invoke("Xin Chao");

            */

            //Viết kiểu khác C2
            Action<string> wellcome;
            wellcome = (s) => Console.WriteLine(s); //~ delegate void KIEU(string s) = Action<string>
            wellcome?.Invoke("Xin Chao");

            //Trường hợp 2 tham số
            Action<string, string> wellcome1;
            wellcome1 = (mgs, name) => Console.WriteLine(mgs + " " + name);
            wellcome1?.Invoke("Xin Chao1", "Nguyen Van A");
            wellcome1?.Invoke("Xin Chao1", "Nguyen Van b");

            //
            Action<string, string> wellcome2;
            wellcome2 = (mgs, name) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(mgs + " " + name);
                Console.ResetColor();
            };
            wellcome2?.Invoke("Xin Chao2", "Nguyen Van A");
            wellcome2?.Invoke("Xin Chao2", "Nguyen Van b");

            //Delegate có kiểu trả về
            //VD
            Func<int, int, int> tinhtoan;

            tinhtoan = (int a, int b) =>
            {
                int kq = a + b;
                return kq;
            };
            Console.WriteLine(tinhtoan?.Invoke(5, 6));

            //Ví dụ về mảng
            int[] mang = { 2, 4, 64, 5, 7, 8, 9, 33, 33 };
            var kq1 = mang.Select(
                (int x) =>
                {
                    return Math.Sqrt(x);
                }
            );
            foreach (var result in kq1)
            {
                Console.WriteLine(result);
            }
            //Duyệt qua mảng kiểu khác
            int[] mang1 = { 2, 4, 64, 5, 7, 8, 9, 33, 33 };
            mang1
                .ToList()
                .ForEach(
                    (x) =>
                    {
                        if (x % 2 != 0)
                        {
                            Console.WriteLine(x);
                        }
                    }
                );
            // Duyệt mảng dùng where
            int[] mang2 = { 2, 4, 64, 5, 7, 8, 9, 33, 33 };
            var kq3 = mang2.Where(
                (x) =>
                {
                    return x % 4 == 0;
                }
            );
            foreach (var n in kq3)
            {
                Console.WriteLine(n);
            }

            // (int a, int b)
            // {
            //    int kq = a +b;
            //    return kq;
            // }
        }
    }
}
