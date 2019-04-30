using FluentValidation;
using Nop.Services.Localization;
using Nop.Web.Areas.Admin.Models.Polls;
using Nop.Web.Framework.Validators;

namespace Nop.Web.Areas.Admin.Validators.Polls
{
    public partial class PollAnswerValidator : BaseNopValidator<PollAnswerModel>
    {
        public PollAnswerValidator(ILocalizationService localizationService)
        {
            //specify rule set for the validation
            RuleSet(NopValidatorDefaults.ValidationRuleSet, () =>
            {
                RuleFor(model => model.Name)
                    .NotEmpty()
                    .WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Answers.Fields.Name.Required"));
            });
        }
    }
}