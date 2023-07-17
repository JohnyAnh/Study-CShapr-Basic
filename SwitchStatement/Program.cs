// string fruit = "apple";
// switch (fruit)
// {
//     case "apple":
//         Console.WriteLine($"App will display information for apple.");
//         break;

//     case "banana":
//         Console.WriteLine($"App will display information for banana.");
//         break;

//     case "cherry":
//         Console.WriteLine($"App will display information for cherry.");
//         break;
// }

int employeeLevel = 100;
string employeeName = "Johny Smith";
string title = "";

switch (employeeLevel)
{
    case 100:

    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}
Console.WriteLine($"{employeeName}, {title}");
