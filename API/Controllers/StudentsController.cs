using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Student>> Get() => _repository.GetAll().ToList();

        [HttpGet("{id}", Name = "GetById")]

        public ActionResult<Student> GetById(int id) => _repository.GetById(id);

        [HttpPost]
        public IActionResult Create(Student student)
        {
            _repository.Create(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, student);
        }

    }
}