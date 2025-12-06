using Library.Application.DTOs.BookDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.BookDTOs.Commands
{
    public class CreateBookCommand : IRequest<BookQueryResult>
    {
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }
    }
}

