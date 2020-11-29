using System.ComponentModel.DataAnnotations;

namespace FormValidation
{
    internal class CustomAttribute
    {
        internal class MinAgeAttribute : ValidationAttribute
        {
            //here we are going to compare the age
            //the age should be above 18
            //declare the variable
            private int minAge;
            public MinAgeAttribute(int val)
            {
                //hera we are just assigning the age to the val variable
                minAge = val;
            }
            //all the validation logic comes here
            protected override ValidationResult IsValid(object val, ValidationContext validationContext)
            {
                if (val != null)
                {
                    if (val is int)
                    {
                        int minimumage = (int)val;
                        if (minimumage < minAge)
                        {
                            return new ValidationResult("Minimum age must be " + minAge);
                        }
                    }
                }
                return ValidationResult.Success;
            }
        }
    }
}