using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("Rents")]
    public class Rents
    {
        [Key]
        public int Id { get; set; }
    }
}
