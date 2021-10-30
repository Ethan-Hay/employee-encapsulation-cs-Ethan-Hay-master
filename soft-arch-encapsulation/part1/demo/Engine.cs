using System;
/*
 * Here's a simple example of property encapsulation -- hiding data and,
 * potentially behavior, by making instance properties private and by choosing
 * getter/setter methods appropriately.
 *
 * Benefits:
 * - no direct access to property values outside of this class
 * (protects against illegal or inappropriate values being assigned or accessed.)
 * - combine with public get and/or set methods for controlled access
 * (setters control values via validation).
 *
 * Note that we can choose to provide getters AND setters for read/write access,
 * or just getters for read-only access. Or, we could make the class immutable by
 * providing a constructor that initializes all properties and eliminating all
 * public setter methods. This class looks immutable, but it's not because the
 * Start() method mutates the state of the running property.
 *
 * Also notice that this class has a Single Responsibility: to do what an
 * Engine can do and nothing more.
 */
namespace soft_arch_encapsulation.part1.demo
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
            // The setter is private. The number of cylinders can't be
            // updated from outside the Engine class.
            private set
            {
                // Setter performs validation using the constants
                if (value < MinCylinders || value > MaxCylinders)
                    throw new ArgumentOutOfRangeException("Invalid cylinder count");
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