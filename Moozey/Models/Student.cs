using Moozey.Models.Base;

namespace Moozey.Models
{
    public class Student : BaseEntity
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }


    }
}
