Console.WriteLine("Ваше имя?");
string name = Console.ReadLine();

if(name.ToLower() == "папа")
{
    Console.WriteLine("Хозяйн! Вы наконец-то вернулись!!!");
}
else
{
    Console.Write("ты мне не нравишься-");
    Console.WriteLine(name);
}