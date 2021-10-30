using System;

namespace soft_arch_encapsulation.part2.demo.good
{
    public class Dog
    {
        // Private backing field
        private int _age;

        // Public property
        public int Age
        {
            // Getter returns private field
            get { return _age; }
            // Setter performs validation before updating. One location
            // for this logic ensures we don't repeat ourselves.
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Age can't be less than zero!");
                _age = value;
            }
        }

        // Constructor uses the setter of the property, enforcing validation
        public Dog(int age)
        {
            Age = age;
        }

        // This method encapsulates the logic of chasing the mail carrier.
        // This ensures that all steps are performed, and in the correct
        // order.
        public void ChaseMailCarrier()
        {
            StartRunning();
            NavigateToMailCarrier();
            CloseGapToMailCarrier();
        }
        
        // Making these methods private ensures they can only be called by the Dog class.
        // Other parts of the program can't call them out of order because
        // we only allow them to call ChaseMailCarrier()
        private void CloseGapToMailCarrier() {}
        private void NavigateToMailCarrier() {}
        private void StartRunning() {}
    }
}