using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace team.BlueApi.Attributes
{
    /// <summary>
    /// Attribute for checking that a single word in a string does not a exceed a given MaxLength
    /// </summary>
    public class MaxLengthSubstringAttribute : ValidationAttribute
    {
        public int MaxLength { get; init; }
        public string GetErrorMessage() => $"A single word in your input should not be longer than {MaxLength} characters";
        public MaxLengthSubstringAttribute(int maxLength) => MaxLength = maxLength;

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            // Null guard, then check if any substring is longer than MaxLength.
            if(!(value is string _value))
                return new ValidationResult("Input was not a string, or it was null.");

            if(_value.Split().Any(s => s.Length > MaxLength))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }
    }
}