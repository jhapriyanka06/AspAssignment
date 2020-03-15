using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssignmentPromact.Models
{
    public class Posts
    {
        [Key]
        public int Post_Id { get; set; }
        
        public string userID { get; set; }
        [Required]
        public string Post { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }
        public User User { get; set; }
     


    }
}
