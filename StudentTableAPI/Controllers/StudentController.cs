using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentTableAPI.Models;
using StudentTableAPI.Repository;

namespace StudentTableAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
      
        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> Get()
        {
            var list = new List<Student>();
            list.AddRange(_studentRepository.Get());
            return list;
        
        }

        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var student = _studentRepository.Get(id);
            return student;
        }

        [HttpPost]
        public void Post(Student student)
        {
            _studentRepository.Add(student);
        }

   
        [HttpPost]
        public void Put(  Student student)
        {
          _studentRepository.Update(student);
           
        }

     

        [HttpPost("{id}")]
        public void Delete(int id)
        {
           _studentRepository.Remove(id);

        }
        [HttpGet("{id}")]
        public Student Find(int id)
        {
            return _studentRepository.Get(id);

        }
    }
}
