using AssignmentPromact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Posts Posts { get; set; }
        public string pageTitle { get; set; }
        public IEnumerable<Posts> posts { get; set; }
        
    }
}
