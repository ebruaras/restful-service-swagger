using swagger_example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace swagger_example.Service
{
    public class SchoolService:ISchoolService
    {
        public static List<Class> classList = new List<Class>
        {
            new Class(){ID=1,Name="1/A",TeacherName="Jane",Population=30},
            new Class(){ID=2,Name="2/A",TeacherName="Bob",Population=20},
            new Class(){ID=3,Name="3/A",TeacherName="Jessie",Population=50},
            new Class(){ID=4,Name="4/A",TeacherName="Hank",Population=25}
        };
        public static List<Student> studentList = new List<Student>
        {
            new Student(){ID=1,Name="Jack",No=111,Gender="M",Age=7,ClassID=2},
            new Student(){ID=2,Name="Skyler",No=111,Gender="F",Age=6,ClassID=1},
            new Student(){ID=3,Name="Thomas",No=111,Gender="M",Age=8,ClassID=3},
            new Student(){ID=4,Name="Linda",No=111,Gender="F",Age=9,ClassID=4},
        };
        public List<Class> GetAllClass()
        {
            return classList;
        }
        public Class GetClassById(int id)
        {
            return classList.Find(x=>x.ID==id);
        }
        public Class GetClassByName(string name)
        {
            return classList.Find(x => x.Name == name);
        }
        public List<Student> GetAllStudents()
        {
            return studentList;
        }
        public List<Student> GetStudentByClass(int classID)
        {
            return studentList.FindAll(x => x.ClassID == classID);
        }
        public Student GetStudentById(int id)
        {
            return studentList.Find(x => x.ID == id);
        }
        public Student GetStudentByName(string name)
        {
            return studentList.Find(x => x.Name == name);
        }
        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }
        public void AddClass(Class _class)
        {
            classList.Add(_class);
        }
    }
}
