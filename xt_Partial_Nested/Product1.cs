using System;
namespace Sanpham
{
    public partial class Product
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public void getInFor()
        {
            Console.WriteLine($"Name: {name} Price: {price} description: {description}");
        }
    }
}