using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiStudent.Domain.Student;

namespace WebApiStudents.Application.IService
{
    public class IStudentService
    {
        List<Student> GetStudents();

        Student GetStudentById(int id);

        Student AddStudent(Student student);

        Student UpdateStudent(int id,Student student);
        Student DeleteStudent(int id);
    }
}
