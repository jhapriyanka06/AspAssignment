using AssignmentPromact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.ViewModels
{
    public class HomeCommentsViewModel
    {
        public Comments comments { get; set; }
        public IEnumerable<Comments> Comments { get; set; }
    }
}
