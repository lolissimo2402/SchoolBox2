using System;
//10. Написати метод, який приймає приймає налебл число(int?). Метод вертає 0 якщо прийов null, в іншому випадку саме число. Перевірку зробити двома способами(if HasValue i ??)
namespace Chapter4.Task10.1
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
            int? i = dr.GetIntFromDatabase();

            if (i.HasValue)
            {
                Console.WriteLine("value  is: {0}", i.Value);
            }

            else
            {
                Console.WriteLine("Value is: 0");
            }

            Console.ReadLine();
        }
    }
}
