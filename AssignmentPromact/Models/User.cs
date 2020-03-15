using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage ="User ID is required")]
        public string userID { get; set; }
        
        [Required(ErrorMessage = "Name field is required")]
        public string UserName { get; set; }
        public List<Posts> post { get; set; }
        
    }
}
