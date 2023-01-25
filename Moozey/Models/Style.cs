namespace Moozey.Models
{
    public class Style
    {   public string Id { get; set; }
        public string NameStyle { get; set; }
        public int NrInstructor { get; set; }
        public int Price { get; set; }

        public ICollection<InstructorStyle> InstructorStyle { get; set; }


    }
}
