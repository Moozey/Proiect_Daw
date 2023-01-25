using Moozey.Models.Base;

namespace Moozey.Models
{
    public class Style : BaseEntity
    {   
        public string NameStyle { get; set; }
        public int NrInstructor { get; set; }
        public int Price { get; set; }

        public ICollection<InstructorStyle> InstructorStyle { get; set; }


    }
}
