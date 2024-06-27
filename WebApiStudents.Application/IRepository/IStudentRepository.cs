using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStudent.Domain.Student;

namespace WebApiStudents.Application.IRepository
{
    public class IStudentRepository
    {
        public List<Student> GetAllStudent();
        public Student AddStudent();

        public Student GetStudentById(int id);

        public Student UpdateStudent(int id,Student student);

        public Student DeleteStudent(int id);
    }
}
