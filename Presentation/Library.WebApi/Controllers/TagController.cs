using Library.Application.DTOs.TagDTOs.Commands;
using Library.Application.DTOs.TagDTOs.Queries;
using Library.Application.DTOs.TagDTOs.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<TagQueryResult>>> GetAll()
        {
            var query = new GetAllTagsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TagQueryResult>> GetById(int id)
        {
            var query = new GetTagByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<TagQueryResult>> Create([FromBody] CreateTagCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TagQueryResult>> Update(int id, [FromBody] UpdateTagCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteTagCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}

