namespace Program
{
    class Products<I>
    {
        I ID;
        public void setID(I _id)
        {
            this.ID = _id;
        }
        public void printID()
        {
            Console.WriteLine($"ID: {ID}");
        }
    }
    class Program
    {
        // static void Swap(ref int x, ref int y)
        // {
        //     int t = x;
        //     x = y;
        //     y = t;
        // }

        static void Swap<T>(ref T x, ref T y)
        {
            T t = x;
            x = y;
            y = t;
        }
        public static void Main(string[] args)
        {
            float x = 5;
            float y = 55;
            Console.WriteLine($"X= {x} Y= {y}");
            Swap<float>(ref x, ref y);
            Console.WriteLine($"X= {x} Y= {y}");
            Console.WriteLine();
            Products<int> sanpham1 = new Products<int>();
            sanpham1.setID(123);
            sanpham1.printID();

            Products<string> sanpham2 = new Products<string>();
            sanpham2.setID("This is generic");
            sanpham2.printID();

            //Gioi thieu 1 so kieu dung Generic List<>; Stack; Queue...
            List<int> danhsach1 = new List<int>();
            Stack<int> stack;
            Queue<double> q;


        }
    }
}