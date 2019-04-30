using System;
using FluentValidation.AspNetCore;

namespace Nop.Web.Framework.Validators
{
    /// <summary>
    /// Represents attribute that used to mark model for the forced validation
    /// </summary>
    [AttributeUsage(AttributeTargets.Parameter, AllowMultiple = false)]
    public class ValidateAttribute : CustomizeValidatorAttribute
    {
        public ValidateAttribute()
        {
            //specify rule set
            RuleSet = NopValidatorDefaults.ValidationRuleSet;
        }
    }
}