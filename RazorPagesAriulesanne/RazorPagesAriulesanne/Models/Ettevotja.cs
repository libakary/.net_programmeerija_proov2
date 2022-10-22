using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesAriulesanne.Models
{
    public class Ettevotja
    {
        public int EttevotjaID { get; set; } //primary key

        [Display(Name = "Juriidiline Nimi")]
        public string JuriidilineNimi { get; set; } = string.Empty;
        public long Registrikood { get; set; }

        [Display(Name = "Osavõtjate arv")]
        public int OsavotjateArv { get; set; }
        public string Maksmisviis { get; set; } = string.Empty;//pangaülekanne v sularaha

        [StringLength(5000)]
        public string? Lisainfo { get; set; } //max 5000 tähemärki

        //igal ettevõtjal võib olla mitu ürituse külastust, seega nendest on kollektsioon
        public ICollection<UrituseKulastused> UrituseKulastuseds { get; set; } = default!;
    }
}
