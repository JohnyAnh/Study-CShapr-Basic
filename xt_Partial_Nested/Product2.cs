namespace Sanpham
{
    public partial class Product
    {
        public class ManuFactory
        {
            public string name { get; set; }
            public string address { get; set; }
            public void getInForFactory()
            {
                Console.WriteLine($"Factory name: {name}");
            }
        }
        public string description { get; set; }
    }
}