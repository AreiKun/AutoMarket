using System;

namespace AutoMarket
{
    [PriceLimit(Price = 300000)]
    public class CarInfo
    {
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime Date { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }

        public CarInfo() { }

        public CarInfo(string model, string registrationNumber, DateTime date, int mileage, int price)
        {
            Model = model;
            RegistrationNumber = registrationNumber;
            Date = date;
            Mileage = mileage;
            Price = price;
        }               
         
        public override string ToString()
        {
            return $"Модель Автомобиля: {Model}, Номер: {RegistrationNumber}, Дата выпуска: {Date}, Пробег: {Mileage}, Цена: {Price}";
        }
    }
}
