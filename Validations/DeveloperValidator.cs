using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDEmployeeAPI.Models;

namespace CRUDEmployeeAPI.Validations
{
    public class DeveloperValidator : AbstractValidator<Employee>
    {
        public DeveloperValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("FirstName should not be empty."); 
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email should not be empty."); ;
            RuleFor(p => p.Age).NotEmpty().WithMessage("Age should not be empty.");
            RuleFor(p => p.Email).EmailAddress().WithMessage("Provide valid Email."); ;
            RuleFor(p => p.Age).GreaterThan(18).WithMessage("Age should be greater than 18"); ; ;
        }
    }
}
