﻿using FluentValidation;
using Nop.Services.Localization;
using Nop.Web.Areas.Admin.Models.Localization;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators.Localization
{
    public partial class LanguageResourceValidator : BaseNopValidator<LocaleResourceModel>
    {
        public LanguageResourceValidator(ILocalizationService localizationService)
        {
            //specify rule set for the validation
            RuleSet(NopValidatorDefaults.ValidationRuleSet, () =>
            {
                RuleFor(model => model.ResourceName)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Resources.Fields.Name.Required"));

                RuleFor(model => model.ResourceValue)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.Configuration.Languages.Resources.Fields.Value.Required"));
            });
        }
    }
}