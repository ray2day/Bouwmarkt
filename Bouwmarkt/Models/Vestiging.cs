using System.ComponentModel.DataAnnotations;

namespace Bouwmarkt.Models
{
    public class Vestiging
    {
        [Key]
        [Display(Name = "Vestigingsnummer")]
        public int VestigingsNummer { get; set; }
        [Required(ErrorMessage = "Naam is verplicht")]
        public string Naam { get; set; }
        [Required(ErrorMessage = "Adresgegevens zijn verplicht")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Plaatsnaam is verplicht")]
        public string Plaats { get; set; }
        [Display(Name = "Telefoonnummer")]
        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        public string TelefoonNummer { get; set; }
    }
}
