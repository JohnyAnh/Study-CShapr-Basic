namespace Virtual
{ //abstract
    abstract class Product // 1 abstract thêm vào đầu class thành 1 class trừu tượng và không được dùng để
    // tạo ra các đối tượng
    {
        protected double Price { get; set; }

        // Phương thức ảo ProductInfo
        public abstract void productInfor(); //3 trong class trừu tượng có thể tạo ra phương thức trừu tượng

        //  thêm từ khóa abstract. Pt này chỉ có tên không có phần thân phương thức


        public void Test() => productInfor();
    }

    class Iphone : Product
    {
        // 4 Sau khi kế thừa cần nạp trồng lại phương thức tại class kế thừa dùng override
        public override void productInfor()
        {
            Price = 500;
            Console.WriteLine("Iphone 14");
            Console.WriteLine($"Giá sản phẩm {Price}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Product p = new Product();2 Cố tình tạo ra đối tượng sẽ xuất hiện lỗi chỉ dùng cho các lớp khác kế thừa
            Iphone ip1 = new Iphone();
            ip1.productInfor();
        }
    }
}
