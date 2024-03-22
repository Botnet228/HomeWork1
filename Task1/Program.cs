Console.WriteLine("Введите целое число :");
string input = Console.ReadLine();
int int_input = Convert.ToInt32(input);

if (int_input % 7 == 0 && int_input % 23 == 0)
{
    Console.WriteLine("Да, число кратно 7 и 23");
}
else
{
    Console.WriteLine("Нет, число не кратно 7 и 23");
}