/*
Code project 1 - write code that validates integer input
    Here are the conditions that your first coding project must implement:

    Your solution must include either a do-while or while iteration.

    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

    Inside the iteration block:
        + Your solution must use a Console.ReadLine() statement to obtain input from the user.
        + Your solution must ensure that the input is a valid representation of an integer.
        + If the integer value is not between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
        + Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
    
    Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted
*/

/*
string? readResult; // Biến để lưu giá trị nhập vào từ bàn phím dưới dạng chuỗi
string valueEntered = ""; // Biến để lưu giá trị được nhập vào bởi người dùng
int numValue = 0; // Biến để lưu giá trị số nguyên sau khi chuyển đổi
bool validNumber = false; // Cờ để kiểm tra tính hợp lệ của số đã nhập

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine(); // Đọc giá trị nhập vào từ bàn phím

    if (readResult != null)
    {
        valueEntered = readResult; // Lưu giá trị đã nhập vào một biến riêng
    }

    validNumber = int.TryParse(valueEntered, out numValue); // Thử chuyển đổi giá trị đã nhập thành số nguyên

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false; // Số không hợp lệ, đặt lại cờ
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false); // Lặp lại vòng lặp cho đến khi số nhập vào là hợp lệ

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine(); // Đọc giá trị nhập vào từ bàn phím một lần nữa (giả sử có đoạn code tiếp theo sau dòng này)
*/

/*
Code project 2 - write code that validates string input
    Here are the conditions that your second coding project must implement:

    Your solution must include either a do-while or while iteration.

    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

    Inside the iteration block:
        Your solution must use a Console.ReadLine() statement to obtain input from the user.
        Your solution must ensure that the value entered matches one of the three role options.
        Your solution should use the Trim() method on the input value to ignore leading and training space characters.
        Your solution should use the ToLower() method on the input value to ignore case.
        If the value entered is not a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
        
    Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/
/*
string? readResult; // Biến để lưu giá trị nhập vào từ bàn phím dưới dạng chuỗi
string roleName = ""; // Biến để lưu giá trị được nhập vào bởi người dùng
bool validEntry = false; // Cờ để kiểm tra tính hợp lệ của số đã nhập

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim(); // Lưu giá trị đã nhập vào một biến riêng
    }
    if (roleName.ToLower() == "administrator" ||roleName.ToLower() == "manager" ||roleName.ToLower() == "user" )
    {
        validEntry = true;
    }
    else
    {
        Console.WriteLine($@"The role name that you entered, ({roleName}) is not valid. Enter your role name (Administrator, Manager, or User)");
    }
} while (validEntry == false);
        Console.WriteLine($"Your input value ({roleName}) has been accepted.");
        readResult = Console.ReadLine();
*/
/*
implement code that achieves the project conditions

    Here are the conditions that your third coding project must implement:

    your solution must use the following string array to represent the input to your coding logic:

    Code
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

    Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

    Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you will process inside the loops should be named myString.

    In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there is no period character in the string, a value of -1 will be returned.

    Your solution must include an inner do-while or while loop that can be used to process the myString variable.

    In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

    In the inner loop, your solution must not display the period character.

    In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length; // Số lượng chuỗi trong mảng
string myString = ""; // Biến để lưu trữ chuỗi được xử lý
int periodLocation = 0; // Vị trí xuất hiện của dấu chấm

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i]; // Lấy chuỗi hiện tại từ mảng

    periodLocation = myString.IndexOf("."); // Tìm vị trí của dấu chấm đầu tiên trong chuỗi

    string mySentence;

    while (periodLocation != -1) // Tiếp tục xử lý cho đến khi không còn dấu chấm trong chuỗi
    {
        mySentence = myString.Remove(periodLocation); // Trích xuất câu từ đầu chuỗi đến dấu chấm
        myString = myString.Substring(periodLocation + 1); // Xóa câu đã xử lý khỏi chuỗi
        myString = myString.TrimStart(); // Loại bỏ khoảng trắng ở đầu chuỗi còn lại
        periodLocation = myString.IndexOf("."); // Tìm vị trí của dấu chấm tiếp theo trong chuỗi
        Console.WriteLine(mySentence); // In ra câu trích xuất
    }

    mySentence = myString.Trim(); // Loại bỏ khoảng trắng ở đầu và cuối chuỗi còn lại (câu cuối cùng)
    Console.WriteLine(mySentence); // In ra câu cuối cùng
}
