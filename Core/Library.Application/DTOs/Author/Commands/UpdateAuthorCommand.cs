using Library.Application.DTOs.Author.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.Author.Commands
{
    public class UpdateAuthorCommand : IRequest<AuthorQueryResult>
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}

