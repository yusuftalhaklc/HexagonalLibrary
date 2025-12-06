using Library.Application.DTOs.TagDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.TagDTOs.Commands
{
    public class CreateTagCommand : IRequest<TagQueryResult>
    {
        public int Name { get; set; }
    }
}

