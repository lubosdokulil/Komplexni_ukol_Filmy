namespace Komplexni_ukol_Filmy.Models
{
    using System.ComponentModel.DataAnnotations; // Nutné pro validace

    public class Film
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Název filmu je povinný.")]
        public string Nazev { get; set; } = "";

        [Required(ErrorMessage = "Rok vydání je povinný.")]
        [RokDoSoucasnosti]
        public int RokVydani { get; set; }

        [Required(ErrorMessage = "Jméno režiséra je povinné.")]
        public string Reziser { get; set; } = "";

        [Required(ErrorMessage = "Žánr je povinný.")]
        public string Zanr { get; set; } = "";

        // Nové políčko pro popis (není povinné, proto nemá [Required])
        public string Popis { get; set; } = "";
    }
}
