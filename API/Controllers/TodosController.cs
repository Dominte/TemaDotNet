using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoRepository _repository;

        public TodosController(ITodoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Todo>> Get() => _repository.GetAll().ToList();


        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Todo> GetById(int id) => _repository.GetById(id);

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
    }
}
