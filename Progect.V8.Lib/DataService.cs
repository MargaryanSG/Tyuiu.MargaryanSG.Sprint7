using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Progect.V8.Lib
{
    [Serializable]
    public class Car
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string TechnicalCondition { get; set; }
        public string Location { get; set; }
        public double AverageSpeed { get; set; }
        public double LoadCapacity { get; set; }
        public double FuelConsumption { get; set; }
    }

    [Serializable]
    public class Driver
    {
        public int EmployeeNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Experience { get; set; }
        public decimal Salary { get; set; }
    }

    [Serializable]
    public class Trip
    {
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Destination { get; set; }
        public double Distance { get; set; }
        public double FuelConsumption { get; set; }
        public double CargoWeight { get; set; }
    }

    [Serializable]
    public class DataService
    {
        public List<Car> Cars { get; private set; }
        public List<Driver> Drivers { get; private set; }
        public List<Trip> Trips { get; private set; }

        public DataService()
        {
            Cars = new List<Car>();
            Drivers = new List<Driver>();
            Trips = new List<Trip>();
        }

        public void SaveToFile(string fileName)
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(stream, this);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка при сохранении в файла: " + ex.Message);
            }
        }

        public void LoadFromFile(string fileName)
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    DataService loadedData = (DataService)binaryFormatter.Deserialize(stream);
                    Cars = loadedData.Cars;
                    Drivers = loadedData.Drivers;
                    Trips = loadedData.Trips;
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Ошибка при загрузке из файла: " + ex.Message);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine("Ошибка десериализации данных: " + ex.Message);
            }


        }
    }
}
