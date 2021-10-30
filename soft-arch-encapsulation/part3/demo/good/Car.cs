namespace soft_arch_encapsulation.part3.demo.good
{
    public class Car
    {
        // Composition is used here. Car objects contain an
        // Engine object.
        // No getters and setters are provided because nothing
        // outside the Car class should interact directly with
        // the engine object.
        private Engine engine;

        // Expression-bodied properties function as getters.
        // Return the read-only property of the engine object.
        public string EngineType => engine.Type;

        public bool IsRunning => engine.IsRunning;

        public Car(int cylinders)
        {
            engine = new Engine(cylinders);
        }

        // Start() and TurnOff() methods in Car delegate to engine object.
        public void Start()
        {
            engine.Start();
        }

        public void TurnOff()
        {
            engine.Stop();
        }
    }
}