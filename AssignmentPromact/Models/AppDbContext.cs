using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentPromact.Models
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Posts> posts { get; set; }
        public DbSet<Comments> comments { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Posts
            modelBuilder.Entity<Posts>().HasData(new Posts { Post_Id = 1, userID = "jha@06", Post = "This Is My First Post...Thankyou",Likes=0,  Comments = 6 });
            modelBuilder.Entity<Posts>().HasData(new Posts { Post_Id = 2, userID = "shus@16", Post = "This Is Shusnavi's First Post...Thankyou", Likes=0,  Comments = 8 });
          
            //seed Comments
            modelBuilder.Entity<Comments>().HasData(new Comments { Comment_Id=1, Post_Id = 1, comments = "Reply To Your Post",Like=0 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Comment_Id = 2, Post_Id = 2, comments = "Reply To Your second Post",Like=0 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Comment_Id = 3, Post_Id = 1, comments = "Reply To Your third Post",Like=0 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Comment_Id = 4, Post_Id = 3, comments = "Reply To Your  Post",Like=0 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Comment_Id = 5, Post_Id = 4, comments = "Reply To You Post",Like=0 });
            modelBuilder.Entity<Comments>().HasData(new Comments { Comment_Id = 6, Post_Id = 2, comments = "Reply To the Post",Like=0 });
        }
    }
}
