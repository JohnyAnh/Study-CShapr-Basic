namespace MyInterface
{ //1.  Interface khai báo ra class interface nhưng không được tạo ra đối tượng khá giống abstract
    // khác là các phương thức chỉ cần khai tên thì mặc định là phương thức trừu tượng lớp cơ sở hay
    // kế thừa phải tự định nghĩa lại phương thức đó
    //Khai báo
    interface IHinhHoc
    {
        public double tinhChuVi();
        public double tinhDienTich();
    }

    class HinhChuNhat : IHinhHoc //3. Chú ý: Khi một class triển khai từ Interface thì cho phép triển khai nhiều giao diện một lúc
    //cách nhau bởi dấu ',' vd: class HinhChuNhat : IHinhHoc, GiaoDien2, GiaoDien3...
    {
        //2 triển khai 2 phương thức tạo ở class Interface đã kế thừa chọn implement interface

        //Ví dụ tính cho hình chữ nhật
        public double a { get; set; }
        public double b { get; set; }

        public double tinhChuVi()
        {
            return 2 * (a + b);
        }

        public double tinhDienTich()
        {
            return a * b;
        }

        public HinhChuNhat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
    }

    class HinhTron : IHinhHoc
    {
        //Tính chu vi diện tích hình tròn
        public double r { get; set; }

        public HinhTron(double _r)
        {
            r = _r;
        }

        public double tinhChuVi()
        {
            return 2 * Math.PI * r;
        }

        public double tinhDienTich()
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Tinh Hinh chữ nhật
            Console.WriteLine("Hình chữ nhật:");
            IHinhHoc h1 = new HinhChuNhat(10, 8);
            Console.WriteLine($"Chu vi: {h1.tinhChuVi()}\nDiện tích: {h1.tinhDienTich()}\n");

            //Tính hình tròn
            Console.WriteLine("Hình tròn:");
            IHinhHoc t1 = new HinhTron(6);
            Console.WriteLine($"Chu vi: {t1.tinhChuVi()}\nDiện tích: {t1.tinhDienTich()}");
        }
    }
}
