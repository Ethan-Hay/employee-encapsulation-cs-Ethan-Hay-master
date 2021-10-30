namespace soft_arch_encapsulation.part3.demo.good
{
        public class Engine
        {
            // Constants are treated as static automatically
            public const int MinCylinders = 1;
            public const int MaxCylinders = 12;
        
            // Private backing field
            private int _cylinderCount;

            // Public property
            public int CylinderCount
            {
                // Getter returns the private field
                get { return _cylinderCount; }
                set
                {
                    // Setter performs validation using the constants.
                    // If invalid, a sensible default is set.
                    if (value < MinCylinders || value > MaxCylinders)
                        _cylinderCount = MinCylinders;
                    else
                        _cylinderCount = value;
                }
            }

            // Private backing field
            private bool _running;

            // Public property with getter and no setter. Updating is done
            // by using the Start() and Stop() methods instead.
            public bool IsRunning
            {
                get { return _running; }
            }

            // Expression-bodied property functions as a getter. It is read-only.
            public string Type => "V" + _cylinderCount;

            // Constructor uses the setter of the property, enforcing validation.
            // Only providing this one constructor ensures that the cylinder count
            // will always be set.
            public Engine(int cylinders)
            {
                CylinderCount = cylinders;
            }

            // These two methods update _running
            public void Start()
            {
                if (!_running)
                    _running = true;
            }

            public void Stop()
            {
                if (_running)
                    _running = false;
            }
        }
    }