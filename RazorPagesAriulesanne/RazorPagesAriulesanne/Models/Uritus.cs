using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesAriulesanne.Models
{
    public class Uritus
    {
        public int UritusID { get; set; } //primary key

        [Display(Name = "Ürituse Nimi")]
        public string UrituseNimi { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Toimumisaeg { get; set; } //ainult tuleviku kp ja kellaaeg??
        public string Toimumiskoht { get; set; } = string.Empty;

        [StringLength(1000)]
        public string? Lisainfo { get; set; } //max 1000 tähte

        //igal üritusel võib olla mitu ürituse külastust, seega nendest on kollektsioon
        public ICollection<UrituseKulastused> UrituseKulastuseds { get; set; } = default!;

    }
}
