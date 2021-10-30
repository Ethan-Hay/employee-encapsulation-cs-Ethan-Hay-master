using System;

/*
 * This demo is an example of Class encapsulation, where entire classes of
 * objects are hidden (encapsulated) from the calling code.
 *
 * This hiding of other classes reduces dependencies that limit flexibility. It
 * also makes the calling code (the code in this class) simpler by hiding
 * details of how the work is performed. "Principle of Least Knowledge" is an
 * important design principle that states that any given class should know the
 * least possible about other classes in the system.
 *
 * Think about how you use your real Car. You don't have to know how a Car works
 * to start the car. You just have to know that you must turn the key. All of
 * the other technical details (there are many!!) are hidden (encapsulated) by
 * that key switch. You know as little as possible about how the rest of the car
 * works.
 */
namespace soft_arch_encapsulation.part3.demo.good
{
    public class Program
    {
        // Only one Main allowed in a C# solution...
        public static void NotMain()
        {
            // Create a car with a 6-cylinder engine and start it
            Car car = new Car(6);
            car.Start();

            // Create a service to report on the car
            CarReportService reportService = new CarReportService(car);
            
            // Print the car report
            Console.WriteLine("Information about your car: ");
            reportService.PrintEngineType();
            reportService.PrintRunningStatus();

            car.TurnOff();
            reportService.PrintRunningStatus();
        }
    }
}