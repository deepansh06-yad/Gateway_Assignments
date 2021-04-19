using System;
using System.Collections.Generic;

namespace Services
{
    public class Service
    {
        public int Add10(int number)
        {
            int counter = 0;
            while (counter++ < 10)
            {
                number++;
            }
            return number;
        }

        public int GetGenderCode(string gender)
        {
            if (gender == null)
            {
                throw new ArgumentNullException();
            }

            switch (gender)
            {
                case "Male":
                    return 1;
                case "Female":
                    return 2;
                case "Other":
                    return 3;
                case "Prefer not to say":
                    return 4;
                default:
                    return -1;
            }
        }

        public bool IsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int FindOddNumbers(List<int> numbers)
        {
            int oddCounter = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    oddCounter++;
                }
            }
            return oddCounter;
        }

        public int Subtract10(int number)
        {
            int counter = 10;
            while (counter-- > 0)
            {
                number--;
            }
            return number;
        }

        public int Divide(int n, int d)
        {
            if (d != 0)
            {
                return n / d;
            }
            else
            {
                throw new InvalidOperationException("Can't divide by zero");
            }
        }

        public void NotImplemented()
        {
            throw new NotImplementedException();
        }

        public bool ValidateName(string name)
        {
            if (name == null)
            {
                throw new FormatException();
            }
            else if (name == "Abhimanyu Singh")
            {
                throw new InvalidNameException();
            }
            else
            {
                return true;
            }
        }
    }
}

[Serializable]
public class InvalidNameException : Exception
{
    public InvalidNameException()
    {

    }

    public InvalidNameException(string name)
        : base(String.Format("Reserved keyword cannot be used as a name: {0}", name))
    {

    }

}
