namespace xt_Null_Nullable
{
    class Abc
    {
        public void XinChao() => Console.WriteLine("Hello C#");
    }
    class Program
    {
        public static void Main(string[] args)
        {
            //null, nullable 
            //Luu y: Bien kieu tham tri(int, double..) khong dc phep gan null 
            //null
            /*
            Abc a = null;
            if (a != null)
                a.XinChao();
            //==>Neu a == null thi phuong thuc khong chay nua
            */
            /*
            Abc a = new Abc();// a khac null thi chay phuong thuc Xinchao()
            if (a != null)
                a.XinChao();
            //Cach viet khac
            a?.XinChao();
             //==>Neu a != null thi phuong thuc Xinchao() duoc chay
            */

            //Kieu tham tri nhan duoc gtri null bang cacb dung nullable
            int? age = null;
            age = 100;
            /*
            //Kiem tra xem bien gtri nullable co gia tri hay khong bang cach
            if (age.HasValue)
            {
                int _age = age.Value;
                Console.WriteLine(_age);
            }
            */


            // Cach khac khong su dung HasValue
            if (age != null)
            {
                int _age = age.Value;
                //  int _age = (int)age; // Ep kieu ket qua tuong tu  
                Console.WriteLine(_age);
            }

        }
    }
}