using Library.Application.DTOs.AuthorDTOs.Commands;
using Library.Application.DTOs.AuthorDTOs.Queries;
using Library.Application.DTOs.AuthorDTOs.Results;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<AuthorQueryResult>>> GetAll()
        {
            var query = new GetAllAuthorsQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AuthorQueryResult>> GetById(int id)
        {
            var query = new GetAuthorByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<AuthorQueryResult>> Create([FromBody] CreateAuthorCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AuthorQueryResult>> Update(int id, [FromBody] UpdateAuthorCommand command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            var command = new DeleteAuthorCommand { Id = id };
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}

