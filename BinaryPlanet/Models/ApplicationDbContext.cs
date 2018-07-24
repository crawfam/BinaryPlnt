using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace BinaryPlanet.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // Add Model Classes Here for Migration into the Database

        // Don't forget to update the Database if the migration looks good
        // How to set up a foreign key: http://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx


        public DbSet<BPUser> BPUsers { get; set; }
        public DbSet<Poem> Poems { get; set; }
        public DbSet<BPUserPoems> BPUserPoems { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

}