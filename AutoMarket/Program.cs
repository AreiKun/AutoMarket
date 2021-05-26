using System;
using System.Threading;

namespace AutoMarket
{
    class Program
    {   
        static void Main(string[] args)
        {
            string carNumber;
            var taxoPark = new TaxoPark();            
            taxoPark.Notify += DisplayMessage;

            try
            {
                Console.WriteLine("Вывожу список");
                taxoPark.DisplayCar();
                do
                {
                    Console.WriteLine("Добавьте новую машину");
                    var carinfo = taxoPark.ConsoleInputCarInfo();
                    taxoPark.AddCar(carinfo);
                    Console.WriteLine("Вывожу список");
                    taxoPark.DisplayCar();
                    Console.WriteLine("Нажмите пробел чтобы добавить ещё один автомобиль, нажмите любую клавишу чтобы завершить. ");
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar);

                Console.WriteLine("Вывожу минимальную цену");
                taxoPark.MinPrice();
                Thread.Sleep(2000);
                Console.WriteLine("Вывожу максимальную цену");
                taxoPark.MaxPrice();
                Thread.Sleep(2000);
                Console.WriteLine("Сортировка по дате производства");
                taxoPark.SortDate();
                Thread.Sleep(2000);
                do
                {
                    Console.WriteLine("Введите номер машины которую хотите отредактировать");
                    taxoPark.DisplayCar();
                    carNumber = Console.ReadLine();
                    taxoPark.EditingCar(carNumber);
                    Console.WriteLine("Вывожу список");
                    taxoPark.DisplayCar();

                    Console.WriteLine("Нажмите пробел чтобы поменять ещё один автомобиль, нажмите любую клавишу чтобы завершить. ");
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }                                   
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
