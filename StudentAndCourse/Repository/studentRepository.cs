using StudentAndCourse.Models;

namespace StudentAndCourse.Repository
{
    public class studentRepository : IStudentRepository
    {
        student[] s = new student[5]
           {
            new student( 1, "Thourai", "011" ),
            new student( 2, "Thourai", "011" ),
            new student( 3, "Thourai", "011" ),
            new student( 4, "Thourai", "011" ),
            new student( 5, "Thourai", "011" )
           };

        public void AddStudent(student student)
        {
            s.Append(student);
        }

        public void deleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<student> getAllStudent()
        {
            return s.ToList();
        }

        public student getStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public void updateStudent(student student)
        {
            throw new NotImplementedException();
        }
    }
}
