using System;

namespace XT_Class
{
    /*
    <Access Modifiers> class Class_Name {
    // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
    // khai báo các thành viên  hàm (phương thức)

    public : không giới hạn phạm vi truy cập
    protected : chỉ truy cập trong nội bộ lớp hay các lớp kế thừa
    private : (mặc định) chỉ truy cập được từ các thành viên của lớp chứa nó
    internal : chỉ truy cập được trong cùng assembly (dll, exe)
    protected internal: truy cập được khi cùng assembly hoặc lớp kế thừa
    private protected: truy cập từ lớp chứa nó, lớp kế thừa nhưng phải cùng assembly
    */
    class VuKhi
    {
        //Dữ liệu
        public string name = "Tên vũ khí:\t "; //Mặc định thì là private
        int doSatThuong = 0;

        //Thuộc tính
        public string noiSanXuat { get; set; }
        public int satThuong
        {
            set
            {
                doSatThuong = value;
                //Các lệnh
                //Console.WriteLine(value); ////Muốn xem giá trị truyền vào thì dùng từ khóa value
            }
            //Truy cập
            get { return 100; }
        }

        //Phương thức khỏi tạo
        public VuKhi()
        {
            doSatThuong = 1;
        }

        public VuKhi(string name, int _doSatThuong)
        {
            this.name = name;
            this.doSatThuong = _doSatThuong;
        }

        //Phương thức
        public void thietLapDoSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
            //this - ref
            // VuKhi abc;
            // abc = this
        }

        public void tanCong()
        {
            Console.Write(this.name + ":\t");
            for (var i = 0; i < doSatThuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}
