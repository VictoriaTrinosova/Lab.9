using System;

namespace Lab._9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ПРИЛОЖЕНИЕ КАЛЬКУЛЯТОР");
            Console.Write("Введите целое число X=");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите целое число Y=");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите код операции");
            Console.WriteLine("1 - сложение");
            Console.WriteLine("2 - вычитание");
            Console.WriteLine("3 - умножение");
            Console.WriteLine("4 - деление");
            Console.Write("Введите выбор:");
            int z = 0;
            try
            {
                Console.Write("Введите выбор:");
                z = Convert.ToInt32(Console.ReadLine());
                if (z > 4 || z<1)
                {
                    throw new Exception("Некорректный ввод");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка:"+ e.Message);
            }
            if (z == 1)
            {
                int s = x + y;
                Console.WriteLine(s);
            }
            if (z == 2)
            {
                int s = x - y;
                Console.WriteLine(s);
            }
            if (z == 3)
            {
                int s = x * y;
                Console.WriteLine(s);
            }
            if (z == 4)

            {
                double s = (double)x / y;
                Console.WriteLine(s);
            }

            Console.ReadKey();
        }
        
    }
}
