﻿List<string> days = new List<string> { "MONDAY","TUESDAY","WEDNESDAY","THURSDAY", "FRIDAY", "SATURDAY","SUNDAY" };
Console.Write("what day is it : ");
string answer = Console.ReadLine();
answer = answer.ToUpper().Trim();


switch (answer) {
    case "MONDAY":
        Console.WriteLine("5 days till weekend :(");
        break;
    case "TUESDAY":
        Console.WriteLine("4 days till weekend :(");
        break;
    case "WEDNESDAY":
        Console.WriteLine("3 days till weekend :(");
        break;
    case "THURSDAY":
        Console.WriteLine("2 days till weekend :(");
        break;
    case "FRIDAY":
        Console.WriteLine("1 days till weekend :(");
        break;
    case "SATURDAY":
    case "SUNDAY":
        Console.WriteLine("WEEKEND :)");
        break;



}
/*
 answer = answer.ToUpper().Trim();
if (answer== days[0]) 

{
    Console.WriteLine("5 days till weekend :(");
}
else if (answer == days[1])

{
    Console.WriteLine("4 days till weekend :(");
}
else if (answer == days[2])

{
    Console.WriteLine("3 days till weekend :(");
}
else if (answer == days[3])

{
    Console.WriteLine("2 days till weekend :(");

}
else if (answer == days[4])

{
    Console.WriteLine("1 days till weekend AND ITS FRIDAY");
}
else if (answer == days[5])

{
    Console.WriteLine("WEEKEND YAY");
}
else if (answer == days[6])

{
    Console.WriteLine("WEEKEND YAY");
}
else
{

    Console.WriteLine("Thats not a day man  ");
}
*/
