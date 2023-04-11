namespace Elearn.Models
{
    public class Course:BaseEntity
    {
        public string? Name { get; set; }

        public string? Descriprion { get; set; }

        public string? Price { get; set; }

        public string? Sale { get; set; }

        public ICollection<CourseImage> Images { get; set; }

        public int CourseHostId { get; set; }

        public CourseHost CourseHost { get; set; }




    }
}
