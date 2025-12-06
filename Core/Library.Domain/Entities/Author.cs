namespace Library.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        // Navigation property
        public virtual ICollection<Book> Books { get; set; }

    }
}
