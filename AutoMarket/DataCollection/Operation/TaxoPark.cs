using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoMarket
{
    class TaxoPark
    {
        public delegate void NumberHandler(string message);
        public event NumberHandler Notify;
        private List<CarInfo> carList;
        CarInfo carInfo = new CarInfo();
        InfoCarValue modelCar = new InfoCarValue();

        public TaxoPark()
        {
           carList = new List<CarInfo>() {new CarInfo() { Model = "Audi", RegistrationNumber = "111B", Date = new DateTime(2015, 10, 5), Mileage = 100000, Price = 10000 },
            new CarInfo() { Model = "Volvo", RegistrationNumber = "CV331B", Date = new DateTime(2000, 10, 5), Mileage = 200000, Price = 10000 },
            new CarInfo() { Model = "BMV", RegistrationNumber = "CV139B", Date = new DateTime(2013, 10, 5), Mileage = 100000, Price = 100005 },
            new CarInfo() { Model = "Honda", RegistrationNumber = "GH8119BZ3", Date = new DateTime(2019, 10, 5), Mileage = 100000, Price = 100500 }};            
        }

        public CarInfo ConsoleInputCarInfo()
        {            
            carInfo.Model = modelCar.EnteringModelValue();
            carInfo.RegistrationNumber = modelCar.EnteringNumberValue();
            carInfo.Date = modelCar.DateEntry();
            carInfo.Mileage = modelCar.EnteringMileageValue();
            carInfo.Price = modelCar.EnteringPriceValue();                
               
            return carInfo;
        }

        public  List<CarInfo> AddCar(CarInfo carInfo)
        {
          carList.Add(carInfo);                
          return carList;
        }        

        public void DisplayCar ()
        {
            foreach (var carInfo in carList)
            {
                Console.WriteLine(carInfo.ToString());
            }
        }

        public void DisplayCar(List<CarInfo> carList)
        {
            foreach (var carInfo in carList)
            {
                Console.WriteLine(carInfo.ToString());
            }
        }

        public void DisplayCar(CarInfo found)
        {
            Console.WriteLine("Модель Автомобиля: {0}, Номер: {1}, Дата выпуска: {2}, Пробег: {3}, Цена: {4}",
                            found.Model, found.RegistrationNumber, found.Date, found.Mileage, found.Price);
        }

        public void MinPrice()
        {
            int minPrice = carList.Min(a => a.Price);
            List<CarInfo> result = carList.FindAll(a => a.Price == minPrice);

            DisplayCar(result);          
        }

        public void MaxPrice()
        {
            int maxPrice = carList.Max(a => a.Price);
            List<CarInfo> result = carList.FindAll(a => a.Price == maxPrice);

            DisplayCar(result);           
        }        

        public void SortDate()
        {
            carList.Sort((x, y) => y.Date.CompareTo(x.Date));
            DisplayCar();            
        }

        public void SearchNumber(string carNumber)
        {
            CarInfo found = carList.Find(numb => numb.RegistrationNumber == carNumber);
            DisplayCar(found);
        }

        

        public void EditingCar(string carNumber)
        {
            try
            {
                do
                {

                    CarInfo found = carList.Find(numb => numb.RegistrationNumber == carNumber);
                    if (found != null)
                    {
                        DisplayCar(found);
                        Console.Write("Укажите новую цену: ");
                        found.Price = modelCar.EnteringPriceValue();
                        carList.Add(found);
                        Notify?.Invoke($"Стоимость изменена на: {found.Price}");
                        DisplayCar(found);
                    }
                    else
                    {
                        Console.WriteLine("Mфшина не найдена");
                        Console.WriteLine("Попробуёте ещё раз");
                    }

                    Console.WriteLine("Нажмите пробел чтобы поменять ещё один автомобиль, нажмите любую клавишу чтобы завершить. ");
                    
                }
                while (Console.ReadKey().Key == ConsoleKey.Spacebar);                                
            }
            catch (Exception) { }
        }
    }
}
