using System.Data.Entity.ModelConfiguration;

namespace CarRental.Data.Configurations
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    
    {
        public PersonConfiguration()
        {
            HasMany(r => r.Rents).WithRequired(r => r.Person);
        }
    }
}
