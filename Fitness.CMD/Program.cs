using FitnessBL.Controller;
using System;


namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует фитнес проложение Zahavr");
            Console.WriteLine("Введите имя пользователя");

            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var dateOfBirthday = DateTime.Parse( Console.ReadLine());//TODO: Переписать

            Console.WriteLine("Введите вес");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = double.Parse( Console.ReadLine());

            var userContoller = new UserController(name, gender, dateOfBirthday, weight, height);
            userContoller.Save();
        }
    }
}
