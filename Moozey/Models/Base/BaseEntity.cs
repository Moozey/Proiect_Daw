using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moozey.Models.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateBegin { get; set; }

        //computed -> pot da si update
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? DateEnd { get; set; }
    }
}
