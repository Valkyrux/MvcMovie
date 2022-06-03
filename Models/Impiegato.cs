using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Impiegato
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Il campo e obbligatorio")]
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string EmailAddress { get; set; }
        public string PersonalWebSite { get; set; }
        public string Photo { get; set; }
        public string AlternateText { get; set; }
    }

    public class ImpiegatoConFile
    {
        [Required(ErrorMessage = "Il campo e obbligatorio")]
        public int Id { get; set; }
        [CustomValidation.MoreThanOneWordValidation]
        public string FullName { get; set; }
        public string Gender { get; set; }
        [StringLength(5, ErrorMessage = "La citta' non puo' avere piu di 5 caratteri")]
        public string City { get; set; }
        public string? EmailAddress { get; set; }
        public string? PersonalWebSite { get; set; }
        public string? Photo { get; set; }
        public string? AlternateText { get; set; }

        public IFormFile File { get; set; }
    }
}
