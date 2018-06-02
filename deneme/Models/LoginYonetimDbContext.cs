using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace deneme.Models
{
    public class LoginYonetimDbContext : DbContext
    {
        public DbSet<Login> login { get; set; }
        public LoginYonetimDbContext():base("Data Source=DESKTOP-SON6OA8;Initial Catalog=aaaa;Integrated Security=True")
        {
           
            Database.SetInitializer<LoginYonetimDbContext>(new DbInitializer());

            
        }
    }

    public class DbInitializer : DropCreateDatabaseAlways<LoginYonetimDbContext>
    {
        protected override void Seed(LoginYonetimDbContext context)
        {
            Login lgn = new Login
            {
                username = "seyma",
                passapord = "12345"
            };
            context.login.Add(lgn);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}