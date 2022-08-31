string name;
string animal;
string scared;
string time;
string pronoun;

Console.WriteLine("vad heter du?");
name = Console.ReadLine();

Console.WriteLine("vilket djur är farligast?");
animal = Console.ReadLine();

Console.WriteLine("vad är du rädd för?");
scared = Console.ReadLine();

Console.WriteLine("vad är ditt pronun han/hon Etc...?");
pronoun = Console.ReadLine();

Console.WriteLine("vad är klockan?");
time = Console.ReadLine();

Console.WriteLine($"{name} blev dödad av 2 {animal} när {pronoun} sprang från {scared} kl {time}!");


Console.ReadLine();
