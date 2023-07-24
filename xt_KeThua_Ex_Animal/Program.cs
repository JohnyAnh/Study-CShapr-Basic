namespace program
{
    /*
    public thành viên có thể truy cập được bởi code bất kỳ đâu.
    private phương thức, thuộc tính, trường khai báo với private chỉ có thể truy cập, gọi bởi các dòng code cùng lớp.
    protected phương thức, thuộc tính, trường chỉ có thể truy cập, gọi bởi các dòng code cùng lớp hoặc các lớp kế thừa nó.
    internal truy cập được bởi code ở cùng assembly (file).
    protected internal truy cập được từ code assembly, hoặc lớp kế thừa nó ở assembly khác.
    private protected truy cập được code khi cùng assembly trong cùng lớp, hoặc các lớp kế thừa nó.
    */
    class Animals
    {
        public int legs;
        public float weigh;
        public void showLeg()
        {
            Console.WriteLine($"Legs: {legs}");
        }
    }

    class Cat : Animals
    {
        public string foods;
        public Cat()
        {
            legs = 4;
            foods = "Mouse";
            weigh = 10;
        }
        public void Eat()
        {
            Console.WriteLine($"Food: {foods}");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Console.WriteLine(" Check cat1:  " + cat1);
            cat1.showLeg();
            cat1.Eat();
        }
    }
}