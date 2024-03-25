namespace Data.Infrastruture.Configurations;

// For use of FluentAPI , you should use from IEntityTypeConfiguration<YOUR_ENTITY>
public class CategoryConfiguration : object, IEntityTypeConfiguration<Category>
{
    public CategoryConfiguration() : base()
    {
    }

    // this method is for Configuration
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(current => current.Id);
            // => it's for KEY [KEY]

        builder
            .Property(propertyExpression: current => current.CategoryName)
            // => select property
            .HasMaxLength(maxLength:100) 
            // => it's max length
            .IsRequired(); 
            // => IsRequired is true if you don't need, write IsRequired(false)
    }
}
