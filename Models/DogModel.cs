
using System.ComponentModel.DataAnnotations;
namespace Dogs.Models
{
    public class DogModel
    {
        //properties
        [Required(ErrorMessage = "Ange ett namn")]
        [Display(Name = "Hundens namn: ")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Ange ålder")]
        [Display(Name = "Hundens Ålder: ")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Ange en ras")]
        [Display(Name = "Ras: ")]
        public string? Breed { get; set; }

        [Required(ErrorMessage = "Ange din email")]
        [EmailAddress]
        [Display(Name = "Din Email: ")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Ange ett kön")]
        [Display(Name = "Ange ett kön: ")]       
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Ange om hunden är kasterad eller inte")]
        [Display(Name = "Är hunden kastrerad?: ")]  
        public string? Neutered{ get; set; }

        [Required(ErrorMessage = "Du måste godkänna att dina uppgifter sparas")]
        [Display(Name = "Jag godkänner att mina uppgifter sparas: ")]       
        public bool Approve { get; set; }
    }
}