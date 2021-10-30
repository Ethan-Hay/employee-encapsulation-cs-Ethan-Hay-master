using System;

/*
 * This is another poor example of encapsulation, but from a different
 * perspective. Here we have a class "Program" that collaborates with two other
 * classes -- "Engine" and "Car".
 * 
 * Think for a minute. Do most people interact with their engines? No! We interact
 * with our car and our car interacts with the engine. For most people the details
 * of how an engine work are not of interest and beyond the comfort level of the
 * average car owner.
 * 
 * Requiring communication with both the car and the engine just complicates things.
 * And when your code is complex, many bad things tend to happen, including poor
 * performance, difficult maintenance, and a greater chance of introducing bugs
 * in the code, however unintentional they might be.
 * 
 * Furthermore, now the "Program" class is dependent on two classes -- "Car" and
 * "Engine". Dependencies are bad because they limit code reuse. The more
 * dependencies you have the worse things get. We don't need the "Engine" object
 * at all here (see good example).
 */
namespace soft_arch_encapsulation.part3.demo.poor
{
    public class Program
    {
        // Only one Main method per C# solution
        public static void NotMain()
        {
            // Why do we need to talk to the Engine? Overly complex!
            Engine engine = new Engine();
            // Is this really necessary?
            engine.CylinderCount = 6;

            Car car = new Car();
            // What happens if you forget to do this? Try commenting this line out.
            // See what you get? It's too easy to make a mistake.
            car.Engine = engine;
            // Is this what you do? Do you tell the engine to start? No!
            // You tell the car to start by turning a key.
            engine.Start();
            
            // Again ... we're talking to the wrong object... should be car!
            Console.WriteLine("Car running status: " + car.Engine.IsRunning);
            Console.WriteLine("Engine cylinders: " + car.Engine.CylinderCount);
        }
    }
}