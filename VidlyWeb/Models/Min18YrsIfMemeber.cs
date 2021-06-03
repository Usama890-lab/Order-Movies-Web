﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VidlyWeb.Models
{
    public class Min18YrsIfMemeber : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;


            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer must be at least 18 yrs old to get membership.");
        }
    }
}
