using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesAriulesanne.Models
{
    public class Eraisik
    {
        public int EraisikID { get; set; } //primary key
        public string Eesnimi { get; set; } = string.Empty;
        public string Perekonnanimi { get; set; } = string.Empty;
        public long Isikukood { get; set; }
        public string Maksmisviis { get; set; } = string.Empty; //pangaülekanne v sularaha 

        [StringLength(1500)]
        public string? Lisainfo { get; set; } //max 1500 tähemärki

        //igal eraisikul võib olla mitu ürituse külastust, seega nendest on kollektsioon
        public ICollection<UrituseKulastused> UrituseKulastuseds { get; set; } = default!;
    }
}
