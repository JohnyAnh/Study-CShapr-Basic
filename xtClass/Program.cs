/*
    <Access Modifiers> class Class_Name {
    // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
    // khai báo các thành viên  hàm (phương thức)

    Trong đó Access Modifiers áp dụng khai báo cho lớp có thể là: public (không giới hạn truy cập)
    hoặc internal (mặc định nếu không khai báo, giới hạn truy cập trong cùng assembly - chương trình).
    Nếu lớp con khai báo lồng trong một lớp khác còn có thể sử dụng private (chỉ truy cập được từ lớp chứa nó)

    Khai báo và khởi tạo thành viên dữ liệu (biến, trường dữ liếu) giống với khai báo biến thông thường, nhưng có
    thêm Access Modifiers để quy định cấp độ truy cập. Đối với thành viên lớp (biến, thuộc tính, phương thức) thì
    có thể áp dụng các access modifiers sau:

    public : không giới hạn phạm vi truy cập
    protected : chỉ truy cập trong nội bộ lớp hay các lớp kế thừa
    private : (mặc định) chỉ truy cập được từ các thành viên của lớp chứa nó
    internal : chỉ truy cập được trong cùng assembly (dll, exe)
    protected internal: truy cập được khi cùng assembly hoặc lớp kế thừa
    private protected: truy cập từ lớp chứa nó, lớp kế thừa nhưng phải cùng assembly
    */
using XT_Class;

//Các class
class Student
{
    public string name;

    public Student(string name)
    {
        this.name = name;
        Console.WriteLine("Khoi tao " + name);
    }

    ~Student()
    {
        Console.ForegroundColor = ConsoleColor.Red; // Đổi màu chữ console
        Console.WriteLine("Huy" + name);
        Console.ResetColor(); //Reset màu chữ
    }
}

class Program
{
    public static void Main(string[] args)
    {
        //Phương thức hủy
        for (var i = 0; i < 100000; i++)
        {
            Student student = new Student("Sinh vien " + i);
            student = null;
        }

        /*
        VuKhi sungLuc = new VuKhi();
        Console.WriteLine(sungLuc.name);

        sungLuc.noiSanXuat = "My";
        Console.WriteLine(sungLuc.noiSanXuat);

        sungLuc.thietLapDoSatThuong(5);
        sungLuc.tanCong();

        VuKhi sungMay = new VuKhi("Sung may", 15);
        sungMay.tanCong();
        */
    }
}
