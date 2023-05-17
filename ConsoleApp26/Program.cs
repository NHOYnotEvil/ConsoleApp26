namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Пистолетов";
            string surname = "Володя";
            string correction;

            Console.WriteLine("Ваше имя - " + name + ". Ваша фамилия - " + surname + ".");

            correction = name;
            name = surname;
            surname = correction;

            Console.WriteLine("Ваше имя - " + name + ". Ваша фамилия - " + surname + ".");
        }
    }
}