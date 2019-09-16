using System;
//10. Написати метод, який приймає приймає налебл число(int?). Метод вертає 0 якщо прийов null, в іншому випадку саме число. Перевірку зробити двома способами(if HasValue i ??)
namespace Chapter4.Task10a
{
    class Program
    {

        public int? firstValue = null;

        public int? GetIntFromDatabase()
        {
            return firstValue;
        }

        static void Main(string[] args)
        {
            Program dr = new Program();
            int? myValue= dr.GetIntFromDatabase() ?? 25;
            Console.WriteLine("value is: {0}", myValue);

            Console.ReadLine();
        }
    }
}