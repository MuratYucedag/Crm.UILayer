using Crm.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel adı boş geçilemez");
            RuleFor(x => x.EmployeePassword).NotEmpty().WithMessage("Personel şifresi boş geçilemez");
            RuleFor(x => x.EmployeeMail).NotEmpty().WithMessage("Personel mail boş geçilemez");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Personel soyadı boş geçilemez");
            RuleFor(x => x.EmployeeGender).NotEmpty().WithMessage("Personel cinsiyet boş geçilemez");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri giriniz");
            RuleFor(x => x.EmployeeSurname).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri giriniz");
        }
    }
}
