using System.Data.Entity.ModelConfiguration;

namespace CarRental.Data.Configurations
{
    public class AuthInfoConfiguration : EntityTypeConfiguration<AuthInfo>
    {
        public AuthInfoConfiguration()
        {
            HasRequired(r => r.Person).WithRequiredPrincipal(r => r.AuthInfo);
            
            HasMany(a => a.Role)
                .WithMany(r => r.AuthInfo)
                .Map(ar =>
            {
                ar.ToTable("AuthInfoRole");
                ar.MapLeftKey("AuthInfoRefId");
                ar.MapRightKey("RoleRefId");
            });
        }
    }
}
