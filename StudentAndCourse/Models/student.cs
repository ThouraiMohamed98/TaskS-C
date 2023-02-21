namespace StudentAndCourse.Models
{
    public class student
    {
        public student(int id, string name, string phone)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }
}
