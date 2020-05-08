using swagger_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger_example.Service
{
    interface ISchoolService
    {
        List<Class> GetAllClass();  //+
        Class GetClassById(int id); //+
        Class GetClassByName(string name); //+

        List<Student> GetAllStudents(); //+
        List<Student> GetStudentByClass(int classID); //+
        Student GetStudentById(int id); //+
        Student GetStudentByName(string name); //+

        void AddStudent(Student student);
        void AddClass(Class _class);
    }
}
