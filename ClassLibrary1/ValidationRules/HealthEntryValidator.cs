using FluentValidation;
using HealthAndFinance.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndFinance.Business.ValidationRules
{
    public class HealthEntryValidator : AbstractValidator<HealthEntry>
    {
       public HealthEntryValidator()
        {
            RuleFor(x => x.Height).NotEmpty().WithMessage("Uzunluk kısmını boş bırakmayınız.");
            RuleFor(x => x.Weight).NotEmpty().WithMessage("Kilo kısmını boş bırakmayınız.");
            RuleFor(x => x.SleepHours).NotEmpty().WithMessage("Haftalık uyuma saatinizi boş bırakmayınız.");
        }
    }
}
