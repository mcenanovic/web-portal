using FluentValidation;
using WebPortal.Core.ArticleManagement.Entities;

namespace WebPortal.Core.ArticleManagement.Validators
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Description is required");
            RuleFor(x => x.CreatedDateTime).NotEmpty().WithMessage("Time of creation is required");
            RuleFor(x => x.UpVote).GreaterThanOrEqualTo(0).WithMessage("Up vote must be greater of equal to zero");
            RuleFor(x => x.DownVote).GreaterThanOrEqualTo(0).WithMessage("Down vote must be greater of equal to zero");
        }
    }
}
