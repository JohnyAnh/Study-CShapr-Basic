namespace Virtual
{
    class Product
    {
        protected double Price { get; set; }

        // Phương thức ảo ProductInfo
        public virtual void productInfor()
        {
            Console.WriteLine($"Gia san pham {Price}");
        }

        public void Test() => productInfor();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;

        // override - nap chong phuong thuc tai lop ke thua khai phuong thuc y het. thay virtual = override
        public override void productInfor()
        {
            Console.WriteLine("Iphone 15");
            // base.productInfor(); //them base nếu muốn dùng phương thưc nguyên bản chưa bị ghi đè override
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Iphone iphone = new Iphone();
            iphone.Test();
        }
    }
}
