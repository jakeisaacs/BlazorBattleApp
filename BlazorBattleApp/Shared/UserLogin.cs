using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattleApp.Shared
{
    public class UserLogin
    {
        [Required (ErrorMessage = "You need a username silly...")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
