
Console.WriteLine("en fragesport score keaping is like golf less is more.");

string name = "name";

Console.WriteLine($"write your {name}");
name = Console.ReadLine();

Console.WriteLine();
string answered_3 = "3";
string testbud;
int answeer = 0;
int scoooooore = 0;
string gogol = "10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000";
string qusetion_1 = "1";
string failed_1 = "1";
string answered_2 = "2";
string complete = "no";

Console.WriteLine($"What number class is this {gogol}");
while (answered_2 == "2")
{
    if (failed_1 == "1")
    {
        Console.WriteLine("A(10^10^10) B(gogol) C(ininity) D(none of the ones to the left)");
        qusetion_1 = Console.ReadLine();
        if (qusetion_1 == "A")
        {
            failed_1 = "0";
        }
        else if (qusetion_1 == "B")
        {
            answered_2 = "1";
            Console.WriteLine("Correct answer! good job.");
            scoooooore -= 10;
            complete = "yes";
        }
        else if (qusetion_1 == "C")
        {
            failed_1 = "0";
        }
        else if (qusetion_1 == "D")
        {
            failed_1 = "0";
        }
        else
        {
            failed_1 = "3";
        }
    }
    else if (failed_1 == "0")
    {
        Console.WriteLine("Wrong answer correct answer was B(gogol)");
        scoooooore += 100;
        complete = "yes";
    }
    else if (failed_1 == "3")
    {
        Console.WriteLine("Syntax Error: Answer A, B, C or D.");
        qusetion_1 = Console.ReadLine();
        if (qusetion_1 == "A")
        {
            failed_1 = "0";
        }
        else if (qusetion_1 == "B")
        {
            answered_2 = "1";
            Console.WriteLine("Correct answer! good job.");
            scoooooore -= 10;
            complete = "yes";
        }
        else if (qusetion_1 == "C")
        {
            failed_1 = "0";
        }
        else if (qusetion_1 == "D")
        {
            failed_1 = "0";
        }
        
    }
    if (complete == "yes")
    {
        Console.WriteLine($"{name} your score is now: {scoooooore}");
        answered_2 = "1";
    }

}
complete = "no";
Console.WriteLine($"how meny zeros were in gogol({gogol})");
while (answered_2 == "1")
{
    while (answered_3 == "3")
    {
        testbud = Console.ReadLine();
        if (int.TryParse(testbud, out int result))
        {
            answeer = result;
            answered_3 = "2";
        }
        else
        {
        Console.WriteLine("Syntax Error Please write a valid number");
        answered_3 = "3";
        }
    }
        
    if (answeer == 100)
    {
        Console.WriteLine("correct answer! good job");
        scoooooore -= 10;
        complete = "yes";
    }
    else if (answeer > 100)
    {
        Console.WriteLine("Wrong answer =-( The correct answer is 100");
        answeer = answeer - 100;
        scoooooore += answeer;
        complete = "yes";
    }
    else if (answeer < 100)
    {
        Console.WriteLine("Wrong answer =-( The correct answer is 100");
        answeer = 100 - answeer;
        scoooooore += answeer;
        complete = "yes";
    }
    if (complete == "yes")
    {
        Console.WriteLine($"{name} your score is now: {scoooooore}");
        answered_2 = "0";
    }
}



Console.ReadLine();
