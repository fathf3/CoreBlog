using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator() {

            RuleFor(x => x.writerName).NotEmpty().WithMessage("Yazar Adı boş girilimez");
            RuleFor(x => x.writerMail).NotEmpty().WithMessage("Mail boş girilimez");
            RuleFor(x => x.writerPassword).NotEmpty().WithMessage("Şifre boş girilimez");
            RuleFor(x => x.writerName).MinimumLength(2).WithMessage("İsim en az 2 karakterden olusmalıdır");
            RuleFor(x => x.writerName).MaximumLength(50).WithMessage("İsim en fazla 50 karakterden olusmalıdır");
        }
    }
}
