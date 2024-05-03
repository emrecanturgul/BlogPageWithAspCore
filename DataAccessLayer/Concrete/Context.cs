using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
   public class Context : DbContext 
    {  //migration panelinde default project olarak DataAcessLayer seçilmeli    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EMRE\\SQLEXPRESS;database=CoreBlogDb;integrated security = true;");
        }
        public DbSet<About> Abouts { get; set; } 
        public DbSet<Blog> Blogs { get; set; } 
        public DbSet<Category> Categories { get; set; }  
        public DbSet<Comment> Comments { get; set; } 
        public DbSet<Contact> Contacts { get; set; } 
        public DbSet<Writer>  Writers { get; set; } 


         
    }
}
