using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "login is required")]
        [StringLength(10, ErrorMessage = "Name can't be longer than 10 characters")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(10, ErrorMessage = "Address cannot be loner then 10 characters")]
        public string Password { get; set; }
    }
}