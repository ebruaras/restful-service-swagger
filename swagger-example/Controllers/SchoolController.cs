using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using swagger_example.Models;
using swagger_example.Service;

namespace swagger_example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        SchoolService schoolService;
        public SchoolController()
        {
            schoolService = new SchoolService();
        }
        //GET api/GetAllClass
        [HttpGet("GetAllClass")]
        public ActionResult<List<Class>> GetAllClass()
        {
            return schoolService.GetAllClass();
        }

        //GET api/GetClassById/{id}
        [HttpGet("GetClassById/{id}")]
        public Class GetClassById(int id)
        {
            return schoolService.GetClassById(id);
        }

        //GET api/GetClassByName/{name}
        [HttpGet("GetClassByName/{name}")]
        public Class GetClassByName(string name)
        {
            return schoolService.GetClassByName(name);
        }

        //GET api/GetAllStudents
        [HttpGet("GetAllStudents")]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return schoolService.GetAllStudents();
        }

        //GET api/GetStudentByClass/{classId}
        [HttpGet("GetStudentByClass/{classId}")]
        public List<Student> GetStudentByClass(int classId)
        {
            return schoolService.GetStudentByClass(classId);
        }
        
        //GET api/GetStudentById/{id}
        [HttpGet("GetStudentById/{id}")]
        public Student GetStudentById(int id)
        {
            return schoolService.GetStudentById(id);
        }

        //GET api/GetStudentByName/{name}
        [HttpGet("GetStudentByName/{name}")]
        public Student GetStudentByName(string name)
        {
            return schoolService.GetStudentByName(name);
        }

        //POST api/AddStudent
        [HttpPost("AddStudent")]
        public void AddStudent([FromBody] Student student)
        {
            schoolService.AddStudent(student);
        }

        //POST api/AddClass
        [HttpPost("AddClass")]
        public void AddClass([FromBody]Class _class)
        {
            schoolService.AddClass(_class);
        }
    }
}