using Library.Application.DTOs.BookTagDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.BookTagDTOs.Commands
{
    public class UpdateBookTagCommand : IRequest<BookTagQueryResult>
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int TagId { get; set; }
    }
}

