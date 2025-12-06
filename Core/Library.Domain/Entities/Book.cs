namespace Library.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
        // Navigation property
        public virtual Category Category { get; set; }
        public virtual Author Author { get; set; }
    }
}
