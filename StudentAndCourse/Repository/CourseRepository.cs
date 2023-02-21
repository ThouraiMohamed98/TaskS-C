using StudentAndCourse.Models;

namespace StudentAndCourse.Repository
{
    public class CourseRepository : ICourseRepository
    {
        course[] courses = new course[5]
           {
               new course(1, "Angular", "level4"),
               new course(2, "js", "level1"),
               new course(3, "css", "level2"),
               new course(4, "html", "level1"),
               new course(5, "bootstrap", "level1")
           };

        public void AddCourse(course course)
        {
            courses.Append(course);
        }

        public List<course> GetCourse()
        {
            return courses.ToList();
        }

        public course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCourse(course course)
        {
            throw new NotImplementedException();
        }
    }
}
