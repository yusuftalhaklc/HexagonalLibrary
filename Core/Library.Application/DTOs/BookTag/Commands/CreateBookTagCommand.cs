using Library.Application.DTOs.BookTag.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.BookTag.Commands
{
    public class CreateBookTagCommand : IRequest<BookTagQueryResult>
    {
        public int BookId { get; set; }
        public int TagId { get; set; }
    }
}

