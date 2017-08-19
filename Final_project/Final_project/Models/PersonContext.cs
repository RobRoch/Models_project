using System.Data.Entity;

namespace Final_project.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("Final_project")
        {

        }
        //Creating DBs using Entity Framework - able to add,remove,update etc.
        public DbSet<Person> Persons { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<FavoritePerson> StashedFavoritePersons { get; set; }
    }
}