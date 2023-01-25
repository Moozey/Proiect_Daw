namespace Moozey.Models
{
    public class InstructorStyle
    {
        public Guid InstructorId { get; set; }
        public Instructor Instructor { get; set; }

        public Guid StyleId { get; set; }
        public Style Style { get; set; }
  
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
