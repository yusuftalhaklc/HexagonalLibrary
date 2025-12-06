using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.BookTagDTOs.Commands
{
    public class DeleteBookTagCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}

