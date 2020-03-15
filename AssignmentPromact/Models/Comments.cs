﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssignmentPromact.Models
{
    public class Comments
    {
        [Key]
        public int Comment_Id { get; set; }
        public int Post_Id { get; set; }
        public string comments { get; set; }
        public int Like { get; set; }
        public Posts Posts { get; set; }
    }
}
