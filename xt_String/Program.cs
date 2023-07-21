class Program
{
    public static void Main(string[] args)
    {
        string loichao; //null
        loichao = "    Xin chao";
        string ten = " HOANG ANH ";

        string thongbao = loichao + ten;
        int dodaichuoi = thongbao.Length;
        char c = ten[4];

        //thongbao = thongbao.Trim(); //Cát khoảng trắng 2 đầu hoặc ký tự đặc biệt ở đầu và cuối vd cắt **** Trim('*');
        //Thay Trim() bằng ToLower() tát cả viết thường
        /*
        method	Sử dụng
        Concat	phương thức tĩnh, nối các chuỗi liệt kê ở tham số lại với nhau
                string s = String.Concat(stringA, stringB);    // s = "Xin chào,các bạn!"
        Format	Convert các đối tượng thành chuỗi và chèn chúng vào chuỗi định dạng được chỉ ra, cú pháp cơ bản
                String.Format(stringFormat, arg0, arg1 ...)
                 Trong đó stringFormat là chuỗi định dạng, chứa mẫu và và vị trí mà arg0, arg1 ... sẽ chèn vào.

                string s = String.Format("Chào {0}, {0} ơi, hôm nay ngày {1} rồi!", "Nam", DateTime.Now.Day);
                // s = "Chào Nam, Nam hôm nay ngày 20 rồi!"
                Nhìn vào, chuỗi định dạng chỗ nào có {0} sẽ được chèn bởi arg0("Nam"), chỗ nào có {1} sẽ được chèn bởi arg1 (20)

                Tại các vị trí cần chèn {} có thể định dạng dữ liệu chèn vào, chi tiết xem tại Formatting

        IndexOf	    Tìm vị trí (đầu tiên) của ký tự hoặc chuỗi ký tự trong chuỗi
        LastIndexOf	Tìm vị trí (cuối) của ký tự hoặc chuỗi ký tự trong chuỗi
        Insert	    Tạo chuỗi = chèn chuỗi này vào trong chuỗi khác, vị trí chèn cần chỉ ra
                    var s = stringA.Insert(8, " tất cả"); // "Xin chào tất cả,"
        PadLeft	    Tạo chuỗi mới từ chuỗi cũ, độ dài chuỗi mới chỉ ra - nếu độ dài chuỗi mới lớn hơn chuỗi cũ thì các ký tự phía đầu được chèn khoảng trắng hoặc ký tự chỉ định.
                    string s1 = "Abc";
                    string s2 = s1.PadLeft(6);        //  "   Abc"
                    string s3 = s1.PadLeft(6, '*');   //  "***Abc"
        PadRight	Tương tự PadLeft nhưng chèn khoảng trắng bên phải
        Replace	    Tìm và thay thế trong chuỗi
                    var s = stringA.Replace("chào", "CHÀO");   // "Xin CHÀO,"
        Split	    Trả về mảng các chuỗi con được chia từ chuỗi gốc bởi ký tự chia chỉ định, chuỗi chia chỉ định
                    var s = "Nguyễn Văn A".Split(' '); // s tương đương mảng {"Nguyễn","Văn", "A"}
        ToLower	    Sinh chuỗi mới bằng cách chuyển các ký tự thành chữ thường
        ToUpper	    Sinh chuỗi mới bằng cách chuyển các ký tự thành chữ in
        Trim	    Sinh chuỗi mới bằng cách loại bỏ khoảng trắng (hoặc chỉ định) ở đầu và cuối
        Substring	Lấy ra chuỗi con từ chuỗi chính - chuỗi con lấy từ vị trí chỉ ra đến cuối hoặc theo độ dài
                    string s = stringA.Substring(4); // s = "chào,"
                    string x = stringA.Substring(0, 3); // s = "Xin" (dài 3)
        */

        // Chia chuỗi thành các mảng con
        string[] tachthanhchuoicon = thongbao.Split(' ');
        foreach (var item in tachthanhchuoicon)
        {
            Console.WriteLine(item);
        }

        // nối các chuỗi con thành 1 mảng
        string[] noicacmangconthanh1 = { "Hoc", "lap", "trinh", "voi", "toi" };
        thongbao = string.Join(' ', noicacmangconthanh1);

        Console.WriteLine(thongbao);
        Console.WriteLine(dodaichuoi);
        Console.WriteLine(c);

        // for (var i = 0; i < dodaichuoi; i++)
        // {
        //     char d = thongbao[i];
        //     Console.WriteLine($"Chỉ số {i} là ký tự {d, 3} ");
        // }

        // foreach (var item in thongbao)
        // {
        //     Console.WriteLine($"Chỉ số {item} là ký tự thứ ");
        // }
    }
}
