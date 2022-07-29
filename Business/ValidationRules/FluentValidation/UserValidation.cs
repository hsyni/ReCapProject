using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.FirstName).MinimumLength(2);
            //RuleFor(u => u.Email).Must(EMailControl);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.LastName).MinimumLength(2);
        }
    }
}
