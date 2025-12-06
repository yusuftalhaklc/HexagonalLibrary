using Library.Application.DTOs.Author.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Author.Queries
{
    public class GetAuthorByIdQuery : IRequest<AuthorQueryResult>
    {
        public int Id { get; set; }
    }
}

