﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CookiesShop.Models
{
    public class Users
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="UserName is required")]
        [MaxLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage="Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        [Required]
        public int RoleID { get; set; }

        [ForeignKey("RoleID")]
        public Role Role { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Orders> Orders { get; set; }

    }
}
