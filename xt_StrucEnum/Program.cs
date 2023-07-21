using System;

class Program
{
    //Struct
    public struct Product
    {
        //Kiểu liệt kê enum
        /*
        0 - Kem
        1 - Trung Binh
        2 - Kha
        3 - Gioi
        */
    }

    enum HOCLUC
    {
        Kem = 10,
        TrungBinh = 123,
        Kha = 333,
        Gioi = 444
    }

    public static void Main(string[] args)
    {
        //Enum
        HOCLUC hocluc;
        hocluc = HOCLUC.Kha;

        //Ép kiểu enum sang số
        int so = (int)hocluc;
        //Covert lại
        hocluc = (HOCLUC)(333);
        Console.WriteLine(so);

        switch (hocluc)
        {
            case HOCLUC.Kem:
                Console.WriteLine("Hoc luc kem");
                break;
            case HOCLUC.TrungBinh:
                Console.WriteLine("Hoc luc trung binh");
                break;
            case HOCLUC.Kha:
                Console.WriteLine("Hoc luc kha ");
                break;
            case HOCLUC.Gioi:
                Console.WriteLine("Hoc luc Gioi");
                break;
        }
    }
}
