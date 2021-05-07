using FluentValidation;
using WebPortal.Core.ArticleManagement.Entities;

namespace WebPortal.Core.ArticleManagement.Validators
{
    public class CategoryLookupValidator : AbstractValidator<CategoryLookup>
    {
        public CategoryLookupValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
        }
    }
}
