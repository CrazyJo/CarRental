using System.Data.Entity.ModelConfiguration;

namespace CarRental.Data.Configurations
{
    public class AuthInfoConfiguration : EntityTypeConfiguration<AuthInfo>
    {
        public AuthInfoConfiguration()
        {
            HasMany(a => a.Role)
                .WithMany(r => r.AuthInfo)
                .Map(ar =>
            {
                ar.MapLeftKey("AuthInfoId");
                ar.MapRightKey("RoleId");
                ar.ToTable("AuthInfoRole");
            });
        }
    }
}
