using System.Data.Entity.ModelConfiguration;
using Sale.Models.Model;

namespace Sale.Models.Config
{
    public class AdminConfigurator : EntityTypeConfiguration<Admin>
    {
        public AdminConfigurator()
        {
            Property(c => c.Login).IsRequired();
            Property(c => c.Pass).IsRequired();
            ToTable("AdminConf");
        }
    }
}