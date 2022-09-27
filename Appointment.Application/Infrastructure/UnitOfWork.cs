namespace Appointment.Application.Infrastructure;

public interface UnitOfWork
{
    Task Begin();
    Task Commit();
    void Rollback();
    Task CommitPartial();
    Task Complete();
}