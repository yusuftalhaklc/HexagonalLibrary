using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.BookTagDTOs.Results
{
    public class BookTagQueryResult
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int TagId { get; set; }
        public string? BookTitle { get; set; }
        public int TagName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

