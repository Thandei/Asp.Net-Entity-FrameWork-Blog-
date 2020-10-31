using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogProject.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext():base("blogDb")
        {
            Database.SetInitializer(new BlogInıtıalizer());
        }
        public DbSet<category> Kategoriler { get; set; }
        public DbSet<Blog> Bloglar { get; set; }

    }
}