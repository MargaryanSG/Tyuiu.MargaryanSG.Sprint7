using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Progect.V8.Lib;
using System.Collections.Generic;

namespace Progect.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveAndLoadData()
        {
            DataService dataProcessor = new DataService();
            dataProcessor.Cars.Add(new Car
            {
                LicensePlate = "р000нв 72",
                Brand = "Toyota",
                TechnicalCondition = "Хорошо",
                Location = "Гараж",
                AverageSpeed = 60,
                LoadCapacity = 1000,
                FuelConsumption = 10
            });

            dataProcessor.Drivers.Add(new Driver
            {
                EmployeeNumber = 1,
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                DateOfBirth = new DateTime(1980, 1, 1),
                Experience = 5,
                Salary = 50000
            });

            dataProcessor.Trips.Add(new Trip
            {
                DepartureDate = DateTime.Now,
                ArrivalDate = DateTime.Now.AddHours(5),
                Destination = "Город Тюмень",
                Distance = 200,
                FuelConsumption = 20,
                CargoWeight = 500
            });

            string fileName = "TestDataFile.bin";

            dataProcessor.SaveToFile(fileName);

            DataService loadedData = new DataService();
            loadedData.LoadFromFile(fileName);

            Assert.AreEqual(1, loadedData.Cars.Count);
            Assert.AreEqual(1, loadedData.Drivers.Count);
            Assert.AreEqual(1, loadedData.Trips.Count);

            Assert.AreEqual(dataProcessor.Cars[0].LicensePlate, loadedData.Cars[0].LicensePlate);
            Assert.AreEqual(dataProcessor.Drivers[0].LastName, loadedData.Drivers[0].LastName);
            Assert.AreEqual(dataProcessor.Trips[0].Destination, loadedData.Trips[0].Destination);

            System.IO.File.Delete(fileName);
        }
    }
}