using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("Cars")]
    public class Cars
    {

        [Key]
        public int Id { get; set; }

        public string Marka { get; set; }

        public string Model { get; set; }

        public float Cena { get; set; }
    }
}
