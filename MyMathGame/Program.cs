using MyMathGame;

var menu = new Menu();

var date = DateTime.Now;

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name;
}