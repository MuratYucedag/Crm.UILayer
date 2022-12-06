using Crm.DTO.DTOs.AnnouncementDtos;
using Crm.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementAddValidator : AbstractValidator<AnnouncementAddDto>
    {
        public AnnouncementAddValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Duyuru Başlığı Boş Geçilemez");
            RuleFor(x => x.Publisher).NotEmpty().WithMessage("Duyuru Oluşturan Boş Geçilemez");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Duyuru Başlığı En Fazla 50 Karakter Olabilir");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Duyuru Başlığı En Az 5 Karakter Olabilir");
            RuleFor(x => x.Publisher).MaximumLength(50).WithMessage("Duyuru Oluşturan En Fazla 50 Karakter Olabilir");
            RuleFor(x => x.Publisher).MinimumLength(5).WithMessage("Duyuru Oluşturan En Az 5 Karakter Olabilir");
        }
    }
}
