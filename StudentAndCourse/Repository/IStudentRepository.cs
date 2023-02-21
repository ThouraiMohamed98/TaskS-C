using StudentAndCourse.Models;

namespace StudentAndCourse.Repository
{
    public interface IStudentRepository
    {
        public List<student> getAllStudent();
        public student getStudentById(int id);
        public void AddStudent(student student);
        public void updateStudent(student student);
        public void deleteStudent(int id);
    }
}
