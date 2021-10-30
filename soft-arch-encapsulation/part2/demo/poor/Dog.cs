using System;

namespace soft_arch_encapsulation.part2.demo.poor
{
    public class Dog
    {
        private int _age;

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

        public Dog(int age)
        {
            // DRY violation! The validation occurs here and in the setter.
            if (age < 0)
                throw new ArgumentOutOfRangeException("Age can't be less than zero!");
            _age = age;
        }

        /*
        These methods must be called in this order:

        startRunning();
        navigateToMailCarrier();
        closeGapToMailCarrier();

        Can we enforce that?
         */
        public void CloseGapToMailCarrier()
        {
        }

        public void NavigateToMailCarrier()
        {
        }

        public void StartRunning()
        {
        }
    }
}