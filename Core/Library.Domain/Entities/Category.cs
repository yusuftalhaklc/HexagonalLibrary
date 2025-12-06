namespace Library.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        // Navigation property
        public virtual ICollection<Book> Books { get; set; }
    }
}
