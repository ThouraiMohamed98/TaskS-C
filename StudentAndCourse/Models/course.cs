namespace StudentAndCourse.Models
{
    public class course
    {
        public course(int id, string name, string level)
        {
            this.id = id;
            this.name = name;
            this.level = level;
        }
        public int id { get; set; }
        public string name { get; set; }
        public string level { get; set; }

    }
}
