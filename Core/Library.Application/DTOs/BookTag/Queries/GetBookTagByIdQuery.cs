using Library.Application.DTOs.BookTag.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.BookTag.Queries
{
    public class GetBookTagByIdQuery : IRequest<BookTagQueryResult>
    {
        public int Id { get; set; }
    }
}

