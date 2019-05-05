using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlinePoll.Models
{
    public class Registeration
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
    }
}
