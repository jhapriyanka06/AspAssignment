using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.Models
{
    public interface ICommentsRepository
    {
        IEnumerable<Comments> GetAllComments(int id);
        Comments GetComments(int id);
        
    }
}
