// See https://aka.ms/new-console-template for more information
int points = 0;
int points_possible = 0;

Console.WriteLine("Have you participated in the first written exam? [Yes/No]");
string exam1 = Console.ReadLine()!;
Console.WriteLine("Have you participated in the second written exam? [Yes/No]");
string exam2 = Console.ReadLine()!;

if (exam1 == "yes" || exam1 == "Yes")
{
    Console.WriteLine("How much points did you get? 1-20 ");
    points += int.Parse(Console.ReadLine()!);
    points_possible += 20;
}

if (exam2 == "yes" || exam2 == "Yes")
{
    Console.WriteLine("How much points did you get? 1-20 ");
    points += int.Parse(Console.ReadLine()!);
    points_possible += 20;
}

int percentage = 100 * points / points_possible;

if (percentage >= 89)
{
    Console.WriteLine("Congratulation you have got an A");
}
else if (percentage >= 76)
{
    Console.WriteLine("Congratulation you have got a B");
}
else if (percentage >= 63)
{
    Console.WriteLine("Congratulation you have got a C");
}
else if (percentage >= 50)
{
    Console.WriteLine("Congratulation you have got a D");
}
else
{
    Console.WriteLine("Sorry you didn't pass");
}