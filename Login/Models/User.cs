using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Display(Name="UserName")]
        [Required(ErrorMessage ="Enter User Name ")]
        [MinLength(3, ErrorMessage ="At leat Name 3 char")]
        public string Name { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Password ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [ForeignKey("Role")]
        public int RoleId {  get; set; }  
        public Role? Role { get; set; } 
    }
}
