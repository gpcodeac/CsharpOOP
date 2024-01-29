using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture214.Classes_and_Interfaces
{
    internal abstract class Car : IVehicle
    {
        private string _model;
        private double _fuel;
        private bool _isDriving = false;
        public Car(string model = "", double fuel = 0.0d)
        {
            Model = model;
            Fuel = fuel;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        public async void Drive()
        {
            await DriveAsync();
        }

        private async Task DriveAsync()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving a car.");
                DateTime startTime = DateTime.Now;
                _isDriving = true;
                Task.Run(() =>
                {
                    double fuelConsumptionCheckpoint = 0;
                    double fuelConsumption = 0;
                    while (true)
                    {
                        TimeSpan drivingTime = DateTime.Now - startTime;
                        //fuelConsumption = drivingTime.TotalSeconds * 0.0003;
                        fuelConsumption = drivingTime.TotalSeconds * 2;
                        if (_fuel <= fuelConsumption)
                        {   
                            _fuel = 0;
                            Console.WriteLine("Out of fuel. Stopping.");
                            break;
                        }
                        if (!_isDriving)
                        {
                            _fuel -= fuelConsumption;
                            break;
                        }
                        if (fuelConsumption - fuelConsumptionCheckpoint > 0.5)
                        {
                            Console.WriteLine($"Driving... Fuel consumed: {fuelConsumption}");
                            fuelConsumptionCheckpoint = fuelConsumption;
                        }
                    }
                });
                Console.WriteLine("Driving without await.");
            }
            else
            {
                Console.WriteLine("No fuel.");
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopping a car.");
            _isDriving = false;
        }

        public void Refuel(double fuelToAdd)
        {
            if (fuelToAdd < 0)
            {
                Console.WriteLine("Fuel to add cannot be negative.");
                return;
            }
            Fuel += fuelToAdd;
            Console.WriteLine("Refueling a car.");
        }
    }



}
