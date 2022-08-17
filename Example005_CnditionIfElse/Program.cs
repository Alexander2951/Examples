Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Валя");
}
else
{
    Console.Write  ("Ты кто такой ? ");
    Console.WriteLine(username);
}