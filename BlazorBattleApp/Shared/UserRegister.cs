using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattleApp.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(15, ErrorMessage = "Username too long, 15 characters max, goober!")]
        public string Username { get; set; }
        public string Bio { get; set; }
        [Required, StringLength(50, MinimumLength = 8)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password do not match, smh...")]
        public string ConfirmPassword { get; set; }
        public int StartUnitId { get; set; } = 1;
        [Range(0, 1000, ErrorMessage = "Choose between 0 and 1000, brosephus!!")]
        public int Currency { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users may enter the arena!!!!")]
        public bool IsConfirmed { get; set; } = true;
    }
}
