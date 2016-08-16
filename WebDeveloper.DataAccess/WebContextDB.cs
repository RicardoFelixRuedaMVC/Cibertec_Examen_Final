using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebDeveloper.Model;
namespace WebDeveloper.DataAccess
{
    public class WebContextDB : DbContext
    {

        public WebContextDB() : base("name=WebDeveloperConnectionString")
        {
            Database.SetInitializer(new WebDeveloperInitializer());
        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



    }
}
