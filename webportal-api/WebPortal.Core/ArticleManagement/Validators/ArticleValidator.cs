using FluentValidation;
using WebPortal.Core.ArticleManagement.Entities;

namespace WebPortal.Core.ArticleManagement.Validators
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.Header).NotEmpty().WithMessage("Header is required");
            RuleFor(x => x.SharedCount).GreaterThanOrEqualTo(0).WithMessage("Shared Count must be greater or equal than zero");
        }
    }
}
