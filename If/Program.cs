Console.Write ("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "сидор")
{
    Console.WriteLine ("Это же сам Сидор!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}