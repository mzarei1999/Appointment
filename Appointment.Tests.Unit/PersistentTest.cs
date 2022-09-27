using Appointment.Application.Infrastructure;
using Appointment.Application.Infrastructure.Test;
using Appointment.DataLayer;

namespace Appointment.Tests.Unit
{
    public class PersistentTest
    {
        protected readonly EFDataContext _context;
        protected readonly EFDataContext _readDataContext;
        protected readonly UnitOfWork _unitOfWork;

        public PersistentTest()
        {
            var db = new EFInMemoryDatabase();
            _context = db.CreateDataContext<EFDataContext>();
            _readDataContext = db.CreateDataContext<EFDataContext>();
            _unitOfWork = new EFUnitOfWork(_context);
        }

        protected void Save<T>(T entity)
        {
            _context.Manipulate(_ => _.Add(entity));
        }
    }
}
