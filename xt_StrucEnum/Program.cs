using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //Struct
    public struct Product
    {
        //du lieu
        public string name;
        public double price;
        public string info
        {
            get { return $"Name: {name} price: {price}"; }
        }

        //phuong thuc
        public string getInfo()
        {
            return $"Ten san pham {name} gia tri {price}";
        }

        //Constructor
        public Product(string _name, double _price)
        {
            name = _name;
            this.price = _price;
        }
    }

    public static void Main(string[] args)
    {
        Product sanpham1;
        sanpham1.name = "Iphone";
        sanpham1.price = 1000;

        Product sanPham2 = new Product("Nokia", 900);
        sanPham2 = sanpham1;
        sanPham2.name = "Ip X";

        Console.WriteLine(sanpham1.getInfo());
        Console.WriteLine(sanPham2.getInfo());
        Console.WriteLine(sanPham2.info);
    }
}
