using Library.Application.DTOs.Book.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Book.Queries
{
    public class GetBookByIdQuery : IRequest<BookQueryResult>
    {
        public int Id { get; set; }
    }
}

