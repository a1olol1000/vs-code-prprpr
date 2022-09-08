
Console.WriteLine("hello, what is your name?");

string name = Console.ReadLine();                    //håller koll på ditt namn


System.Console.WriteLine($"Hello {name} This is a short interactive story.");

Console.WriteLine("you and your party are walking alog a road when a giant graywolf suddently jumps out what do you do :Fight or Flee(figt;flee)");
string val1 = Console.ReadLine();

if ( val1 == "figt")                                  // första valet
{
    Console.WriteLine(
        "You chose to fight thee giant graywolf it was a tough batle and elf guy was indjured what do you do :Heal him or Abandon him(heal;aban)"
    );
    string val2_1 = Console.ReadLine();
    if (val2_1 == "heal")
    {
        Console.WriteLine("you heal elf guy and everyone got back safe and sound. The End");
    }
    else if (val2_1 == "aban")
    {
        Console.WriteLine("You abandon elf guy (You monsters) and head to town and sell the loot from the giant graywolf and get to an inn ");
        Console.WriteLine("meanwhile");        
        Console.WriteLine("Elf guy lays down on the ground in excrusiating pain from a small cut on his finger but then (Chose: A or B)"
        );
        string val2_2 = Console.ReadLine();
        if (val2_2 == "A")
        {
            Console.WriteLine("the giant graywolfs pack comes along and eats Him. The End");
        }
        else if (val2_2 == "B")
        {
            Console.WriteLine("The king of the country comes along with his escorts and they quickly healed him then they travveld to the city .");
            Console.WriteLine("The next day");
            Console.WriteLine("you wake up too rapid knoking on your door you answer and you are imidiatly put you under arrest.");
            Console.WriteLine($"later on in the day you are brougt to a wooden platform. Then they say {name} you are being hanged for your crime of atemptal manslaugther by leaving your companyon by them self with an indjury wich could have killed him eventualy and that is why you are being hanged. then you are hanged and you die. The End");
        }
        else
        {
            Console.WriteLine("The whole fucking world explodes and everyone fuking dies an then every one fucking dies. The End");
        }
    }
    else
    {
        Console.WriteLine("You stand there doing nothing and the giant graywolfs pack comes along and eats you all.");
    }
}
else if ( val1 =="flee")                            // andra valet
{
    Console.WriteLine(
        "You flee from the giant gray wolf and run as fast as the wind but the gray wolf runs faster then the wind it caches dwarf gal and you but elf guy and orc lady manage to run to the next town and alert the guards. The End"
    );
}
else                                                 // sista valet ifal du välger fel eller inte alls
{
    System.Console.WriteLine(
        "You did nothing and was eaten alive."
    );
}
Console.ReadLine(); 
