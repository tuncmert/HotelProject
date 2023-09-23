using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator :AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad 2 karakterden az olamaz");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Soyad 2 karakterden az olamaz");
            RuleFor(x => x.City).MinimumLength(2).WithMessage("Şehir 2 karakterden az olamaz");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Ad en fazla 20 karakter olabilir.");
            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Soyad en fazla 30 karakter olabilir.");
            RuleFor(x => x.City).MaximumLength(20).WithMessage("Şehir en fazla 20 karakter olabilir.");
        }
    }
}
