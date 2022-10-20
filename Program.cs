// See https://aka.ms/new-console-template for more information
Console.Clear();
int points = 0;
int max_points = 20;
int points_possible = 20;
int new_grade = 0;
int old_grade = 0;

Console.WriteLine("Have you participated in the first written exam? [Yes/No]");
string exam1 = Console.ReadLine()!;
Console.WriteLine("Have you participated in the second written exam? [Yes/No]");
string exam2 = Console.ReadLine()!;
Console.WriteLine("How much points did you get through homework? 1-20");
int homework_points = int.Parse(Console.ReadLine()!);
points += homework_points;
Console.WriteLine("Did you take an oral exam? [Yes/No]");
string oral_exam = Console.ReadLine()!;

if (exam1 == "yes" || exam1 == "Yes")
{
    Console.WriteLine("How much points did you get in the first exam? 1-20 ");
    points += int.Parse(Console.ReadLine()!);
    points_possible += 20;
}

if (exam2 == "yes" || exam2 == "Yes")
{
    Console.WriteLine("How much points did you get in the second exam? 1-20 ");
    points += int.Parse(Console.ReadLine()!);
    points_possible += 20;
}
if (oral_exam == "yes" || oral_exam == "Yes")
{
    Console.WriteLine("How much points did you get in the oral exam? 1-20 ");
    points += int.Parse(Console.ReadLine()!);
    points_possible += 20;
}

int percentage = 100 * points / points_possible;

if (percentage >= 89)
{
    Console.WriteLine("Congratulation you have got an A");
    old_grade = 1;
}
else if (percentage >= 76)
{
    Console.WriteLine("Congratulation you have got a B");
    old_grade = 2;
}
else if (percentage >= 63)
{
    Console.WriteLine("Congratulation you have got a C");
    old_grade = 3;
}
else if (percentage >= 50)
{
    Console.WriteLine("Congratulation you have got a D");
    old_grade = 4;
}
else
{
    Console.WriteLine("Sorry you didn't pass");
    old_grade = 5;
}

int homework_all = 100 * ((points - homework_points) + max_points) / points_possible;
if (homework_all >= 89)
{
    new_grade = 1;
}
else if (homework_all >= 76)
{
    new_grade = 2;
}
else if (homework_all >= 63)
{
    new_grade = 3;
}
else if (homework_all >= 50)
{
    new_grade = 4;
}
else
{
    new_grade = 5;
}
if (new_grade == old_grade)
{
    Console.WriteLine("If you would hav done all of your homework it wouldn't have changed anything about your grade");
    Console.ReadKey();
}
else
{
    Console.WriteLine("If you would have done all of your homework you would have got a/an " + new_grade + " instead of a/an " + old_grade);
    Console.ReadKey
}
Console.Clear();