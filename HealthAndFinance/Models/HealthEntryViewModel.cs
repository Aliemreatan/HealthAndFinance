using System.ComponentModel.DataAnnotations;

namespace HealthAndFinance.WebUI.Models
{
    public class HealthEntryViewModel
    {
        [Display(Name = "Haftalık Uyku Saati")]
        [Required(ErrorMessage = "Uyku Saatinizi Giriniz.")]
        public double? SleepHours { get; set; }

        [Display(Name = "Kilo")]
        [Required(ErrorMessage = "Kilonuzu giriniz")]
        public int? Weight { get; set; }

        [Display(Name = "Boy")]
        [Required(ErrorMessage = "Boyunuzu Giriniz")]
        public int? Height { get; set; }

        [Display(Name = "Not")]
        public string? Notes { get; set; }

        
    }
}
