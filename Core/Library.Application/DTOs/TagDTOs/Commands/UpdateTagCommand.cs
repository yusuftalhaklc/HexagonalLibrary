using Library.Application.DTOs.TagDTOs.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTOs.TagDTOs.Commands
{
    public class UpdateTagCommand : IRequest<TagQueryResult>
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}

