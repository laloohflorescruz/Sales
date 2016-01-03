using Sales.Models.Model;
using System.Data.Entity.ModelConfiguration;

namespace Sales.Models.Config
{
    public class BooksConfigurator : EntityTypeConfiguration<Book>
    {
        public BooksConfigurator()
        {
            Property(c => c.Name).IsRequired();
            //Property(c => c.Author).IsRequired();
            Property(c => c.YearOfPublication).IsRequired();
            //Property(c => c.ISBN).IsRequired();
            //Property(c => c.Photo).IsRequired().HasColumnType("image"); ;
            //Property(c => c.Price).IsRequired();
            Property(c => c.Count).IsRequired();
            ToTable("Book");
        }
    }
}