using Library.Application.DTOs.AuthorDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.AuthorDTOs.Commands
{
    public class CreateAuthorCommand : IRequest<AuthorQueryResult>
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
    }
}

