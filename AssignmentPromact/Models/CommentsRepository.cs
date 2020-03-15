using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.Models
{
    public class CommentsRepository: ICommentsRepository
    {
        private readonly AppDbContext _appDbContext;
        public CommentsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Posts> GetAllPosts => _appDbContext.posts;
        public IEnumerable<Comments> GetAllComments(int id)
        {
            return _appDbContext.comments.Include(c =>c.Posts).Where(c => c.Post_Id==id);
        }

        public Comments GetComments(int id)
        {
            return _appDbContext.comments.FirstOrDefault(c => c.Comment_Id == id);
        }
    }
}
