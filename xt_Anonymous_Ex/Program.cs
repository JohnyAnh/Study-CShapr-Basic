namespace Anonymoust
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Cu Phap
            var obj = new 
            {
                thuoctinh1 = giatri1,
                thuoctinh2 = giatri2
            };

            Để truy cập thuộc tính của toán tử vẫn dùng ký hiệu . và tên thuộc tính.

            Console.WriteLine(myProfile.name);

            Luu y: Anonymous chi dung de doc
            */

            var myProfire = new
            {
                name = "Johny",
                age = 26,
                adress = "Ha Noi"
            };

            Console.WriteLine(myProfire.name);

        }
    }
}