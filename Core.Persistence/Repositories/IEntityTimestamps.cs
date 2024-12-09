namespace Core.Persistence.Repositories;

public interface IEntityTimestamps
{
    DateTime CreatedDate { get; set; }
    DateTime? UpdateDate { get; set; }
    DateTime? DeletedDate { get; set; }
}
