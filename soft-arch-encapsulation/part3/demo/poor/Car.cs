namespace soft_arch_encapsulation.part3.demo.poor
{
    public class Car
    {
        // This is composition -- the engine object is a component of the Car object
        // But it's used poorly here. Car does not delegate to Engine and it
        // doesn't hide what the Engine does (encapsulation).
        public Engine Engine { get; set; }

        // Is using the default constructor always a good idea?
        // What happens if we forget to set the Engine?
        public Car()
        {
            
        }
    }
}