using System;

namespace AutoMarket
{
    class InfoCarValue : CarInfo, IDataInput
    {
        CarNumberTemplates number = new CarNumberTemplates();
        DateTime dateTimeMin;
        DateTime dateTimeMax;

        public InfoCarValue()
        {
            dateTimeMin = new DateTime(1987, 01, 01);
            dateTimeMax = new DateTime(2021, 05, 05);
        }
        private string ConsoleInputModel()
        {
            try
            {
                do
                {
                    Console.WriteLine("ВВедите название модели: ");
                    Model = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(Model))
                    {                        
                        Console.WriteLine("Сохранено название машины:" + Model);
                    }
                    else
                    {
                        Console.WriteLine("Введено некорректное название модели");
                    }

                    Console.WriteLine("Проверьте правильность ввода, если требуется корректировка нажмите пробел");                                          
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar && !string.IsNullOrWhiteSpace(Model));
                return Model;
            }
            catch (Exception)
            {
                throw;
            }            
        }
        public string EnteringModelValue()
        {
            return ConsoleInputModel();
        }

    private string ConsoleInputRegistrationNumber()
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите регистрационный номер автомобиля: ");
                    RegistrationNumber = Console.ReadLine();
                    if (number.CheckingCompliance(RegistrationNumber))
                    {
                        Console.WriteLine("Сохранён регистрационный номер автомобиля: " + RegistrationNumber);
                    }
                    else
                    {
                        Console.WriteLine("Введён некорректный регистрационный номер автомобиля ");
                    }                        

                    Console.WriteLine("Проверьте правильность ввода, если требуется корректировка нажмите пробел");
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar);
                return RegistrationNumber;
            }
            catch (Exception) { throw; }

        }

    public string EnteringNumberValue()
        {
            return ConsoleInputRegistrationNumber();
        }

        private DateTime ConsoleInputRegistrationDate()
        {
            try
            {
                do
                {
                    Console.Write("Введите дату производства: ");
                    Date = DateTime.Parse(Console.ReadLine());
                    if (Date != null && Date >= dateTimeMin && Date <=dateTimeMax )
                    {
                        Console.WriteLine("Сохранена дата производства:" + Date);
                    }
                    else
                    {
                        Console.WriteLine("Введена некорректная дата ");
                    }

                    Console.WriteLine("Проверьте правильность ввода, если требуется корректировка нажмите пробел");
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar);
                return Date;
            }
            catch (Exception) { throw; }
        }

        public DateTime DateEntry()
        {
            return ConsoleInputRegistrationDate();
        }

        private int ConsoleInputRegistrationMileage()
        {
            try
            {
                do
                {
                    Console.Write("Укажите пробег: ");
                    Mileage = int.Parse(Console.ReadLine());
                    if (Mileage != 0 && Mileage <= 250000 )
                    {
                        Console.WriteLine("Сохранёный пробег: " + Mileage);
                    }
                    else
                    {
                        Console.WriteLine("Введён некорректный пробег ");
                    }

                    Console.WriteLine("Проверьте правильность ввода, если требуется корректировка нажмите пробел");
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar);
                return Mileage;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int EnteringMileageValue()
        {
            return ConsoleInputRegistrationMileage();
        }

        private int ConsoleInputRegistrationPrice()
        {
            try
            {
                do
                {
                    Console.Write("Укажите цену: ");                    
                    Price = int.Parse(Console.ReadLine());
                    if (Price != 0 && Price >= 300 && Price<= 500000)
                    {
                        Console.WriteLine("Сохранённая цена: " + Price);
                    }
                    else
                    {
                        Console.WriteLine("Введена некорректная цена ");
                    }

                    Console.WriteLine("Проверьте правильность ввода, если требуется корректировка нажмите пробел");
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar);
                return Price;
            }
            catch (Exception)
            {
                throw;
            }
        }        

        public int EnteringPriceValue()
        {
            return ConsoleInputRegistrationPrice();
        }
    }
}
