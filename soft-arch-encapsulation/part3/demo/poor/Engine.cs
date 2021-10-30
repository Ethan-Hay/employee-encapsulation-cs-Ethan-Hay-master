namespace soft_arch_encapsulation.part3.demo.poor
{
    public class Engine
    {
        // Should we really be able to change the cylinder
        // count of an existing engine? That doesn't seem
        // like it should be possible.
        public int CylinderCount { get; set; }

        private bool _running;

        public bool IsRunning
        {
            get { return _running; }
        }

        // If we use this constructor, the cylinder count might
        // not get set. What if we forget to use the setter?
        public Engine()
        {
        }

        public void Start()
        {
            _running = true;
        }

        public void Stop()
        {
            _running = false;
        }
    }
}