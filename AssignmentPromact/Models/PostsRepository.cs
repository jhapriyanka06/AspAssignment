﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.Models
{
    public class PostsRepository: IPostsRepository
    {
        private readonly AppDbContext _appDbContext;
        public PostsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

       

        public IEnumerable<Posts> GetAllPosts()
        {
            return _appDbContext.posts;
        }

        public Posts GetPosts(int id)
        {
            return _appDbContext.posts.FirstOrDefault(p => p.Post_Id == id);
        }

        public IEnumerable<Comments> GetAllComments(int id)
        {
            return _appDbContext.comments.Include(c => c.Posts).Where(c => c.Post_Id == id);
        }
    }
}
