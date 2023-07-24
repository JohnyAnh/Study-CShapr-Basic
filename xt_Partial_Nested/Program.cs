using Sanpham;
namespace Program
{
    class Test
    {
        public static void Main(string[] args)
        {
            Sanpham.Product sp1 = new Sanpham.Product();
            sp1.name = "Iphone 14";
            sp1.price = 1000;
            sp1.description = "Ip 14 is so bad";
            sp1.getInFor();
        }
    }
}