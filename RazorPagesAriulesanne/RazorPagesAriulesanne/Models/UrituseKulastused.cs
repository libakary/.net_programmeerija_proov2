using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesAriulesanne.Models
{
    public class UrituseKulastused
    {
        public int ID { get; set; } //primary key
        public int EraisikID { get; set; } //foreign key
        public int EttevotjaID { get; set; } //foreign key
        public int UritusID { get; set; } //foreign key

        //ürituse külastuse võib kasutada vaid üks ettevõtja/eraisik
        public Ettevotja? Ettevotja { get; set; }
        public Eraisik? Eraisik { get; set; }

        //ürituse külastuse võib kasutada vaid üks üritus
        public Uritus Uritus { get; set; } = default!;
    }
}
