//-------------------------------------------------------------------
//                            Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую 
//    день недели, и проверяет, является ли этот день выходным.
//-------------------------------------------------------------------

// Solution With The Class
//-------------------------------------------------------------------
// string? inputLine = Console.ReadLine();
// int numberDay = int.Parse(inputLine);
// if (numberDay == 6 || numberDay == 7)
// {
//     Console.WriteLine("Выходной день");
// }
// else
// {
//     Console.WriteLine("Будний день");
// }

// Use Dictionary
//-------------------------------------------------------------------
void weekend()
{
    Console.WriteLine("Введите число обозначающий день недели");
    string? inputLine = Console.ReadLine();
    int numberDay = int.Parse(inputLine);
    var weekDay = new Dictionary<int, string>()
    {
    {0, "Выходной день"},
    {1, "Будний день"},
    };
    Console.WriteLine((numberDay == 6 || numberDay == 7) ? (weekDay[0]) : (weekDay[1]));
}

weekend();