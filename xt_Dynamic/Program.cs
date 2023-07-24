namespace Dynamic
{
    /* Dynamic - kieu du lieu dong
    Cu Phap
           Biến kiểu động - ngầm định - khai báo với từ khóa dynamic, thì kiểu thực sự của biến đó được xác định bằng đối tượng gán vào ở thời điểm chạy 
           (khác với kiểu ngầm định var kiểu xác định ngay thời điểm biên dịch)

            dynamic myvar;

            Ví dụ khai báo phương thức có sử dụng tham số kiểu dynamic

            static void TestFunc(dynamic dvar) {
                Console.WriteLine(dvar.age); // ở thời điểm biên dịch - không biết dvar có thuộc tính age hay không, nhưng nó vẫn biên dịch
            }

            Với phương thức trên, ở thời điểm chạy mà đối tượng ở tham số có thuộc tính age thì sẽ không lỗi, còn nếu không có thuộc tính age sẽ sinh ngoại lệ.

            var myProfile = new {
                name = "XuanThuLab",
                age = 20,
                skill = "ABC"
            };
            TestFunc(myProfile); // In ra 20
            */

    class Student
    {
        public string name { get; set; }
        public void Hello() => Console.WriteLine(name);
    }


    class Program
    {
        static void printInfor(dynamic obj)
        {
            obj.name = "Johny Vu";
            obj.Hello();
        }
        public static void Main(string[] args)
        {

            Student st = new Student();
            printInfor(st);
        }
    }
}