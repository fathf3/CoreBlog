using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {

        public BlogValidator() 
        {
            RuleFor(x => x.blogTitle).NotEmpty().WithMessage("Blog başlığı boş olamaz");
            RuleFor(x => x.blogTitle).MinimumLength(3).WithMessage("Blog başlığı 3 karakterden az olamaz");
            RuleFor(x => x.blogTitle).MaximumLength(120).WithMessage("Blog başlığı 120 karakterden fazla olamaz");
            RuleFor(x => x.blogContent).NotEmpty().WithMessage("Blog içeriği boş olamaz");
            RuleFor(x => x.bloglImage).NotEmpty().WithMessage("Blog resmi ekelemeniz gerekiyor");
        }

    }
}
