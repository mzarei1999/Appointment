
using Appointment.Application.Infrastructure;

namespace Appointment.DataLayer
{
    public class EFUnitOfWork : UnitOfWork
    {
        private readonly EFDataContext _dataContext;

        public EFUnitOfWork(EFDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Begin()
        {
            await _dataContext.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _dataContext.SaveChangesAsync();
            await _dataContext.Database.CommitTransactionAsync();
        }

        public void Rollback()
        {
            _dataContext.Database.RollbackTransaction();
        }

        public async Task CommitPartial()
        {
            await _dataContext.SaveChangesAsync();
        }

        public async Task Complete()
        {
            await _dataContext.SaveChangesAsync();
        }

    }
}
