using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmını boş geçemezsiniz.");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Lütfen en az 50 Karakterlik açıklama bilgisi giriniz...!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen açıklamayı kısaltın...");

        }
    }
}
