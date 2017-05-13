using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (CustomerModel)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthdayDate == null)
                return new ValidationResult("Birthdate is required");

            var age = DateTime.Now.Year - customer.BirthdayDate.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer must be at least 18 years old to go on a membership"); 

        }
    }
}