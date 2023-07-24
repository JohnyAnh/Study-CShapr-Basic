namespace Anonymoust
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
    class Student
    {
        public string nameStudent { get; set; }
        public int yearStudennt { get; set; }
        public string adressStudent { get; set; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                new Student() {nameStudent= "Nam", yearStudennt = 2000, adressStudent = "Binh Duong"},
                new Student() {nameStudent= "Mo", yearStudennt = 2002, adressStudent = "Nam Dinh"},
                new Student() {nameStudent= "Adi", yearStudennt = 2001, adressStudent = "Vinh Phuc"},
                new Student() {nameStudent= "DaPhat", yearStudennt = 2000, adressStudent = "Nam Dinh"}
            };
            var result = from st in students
                             //  where st.yearStudennt <= 2001
                             //  where st.nameStudent == "Adi"
                             //   where st.nameStudent.Contains("a")//Tim theo ten co chu a
                         where st.adressStudent == "Nam Dinh"
                         select new
                         {
                             nameOf = st.nameStudent,
                             yearOf = st.yearStudennt,
                             adressOf = st.adressStudent
                         };
            foreach (var item in result)
            {
                Console.WriteLine(item.nameOf + " - " + item.yearOf + " - " + item.adressOf);
            }




        }
    }
}