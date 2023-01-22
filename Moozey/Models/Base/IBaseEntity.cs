namespace Moozey.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }

        DateTime DateBegin { get; set; }
        DateTime? DateEnd { get; set; }
    }
}
