using StudentAndCourse.Models;

namespace StudentAndCourse.Repository
{
    public interface ICourseRepository
    {
        public List<course> GetCourse();
        public course GetCourseById(int id);
        public void AddCourse(course course);
        public void RemoveCourse(course course);
    }
}
