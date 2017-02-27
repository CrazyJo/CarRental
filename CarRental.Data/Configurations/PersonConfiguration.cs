using System.Data.Entity.ModelConfiguration;

namespace CarRental.Data.Configurations
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    
    {
        public PersonConfiguration()
        {
            HasMany(r => r.Orders).WithRequired(r => r.Person).WillCascadeOnDelete(false);
        }
    }
}
