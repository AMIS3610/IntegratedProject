using Microsoft.EntityFrameworkCore; 
using VolunteerApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace VolunteerApi.Data {
    public class VolunteerContext : IdentityDbContext<ApplicationUser>       
    {     
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {             
                    string connection = "User ID=postgres;Password=godisgreat2;Host=localhost;Port=5432;Database=VolunteerProjectDB;Pooling=true;";

                    optionsBuilder.UseNpgsql(connection);          
                } 

                public DbSet<Listing> Listings { get; set; } 
                public DbSet<Account> Accounts { get; set; }
    }
}