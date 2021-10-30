using System;

namespace soft_arch_encapsulation.part3.demo.good
{
    public class CarReportService
    {
        private Car car;

        public CarReportService(Car car)
        {
            this.car = car;
        }

        public void PrintEngineType()
        {
            Console.WriteLine("Engine Type: " + car.EngineType);
        }

        public void PrintRunningStatus()
        {
            Console.WriteLine("Car running status: " + car.IsRunning);
        }
    }
}