using Practical_18.Models;
using Practical_20.Interfaces;

namespace Practical_20.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        private IStudentRepository _studentRepository;


        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IStudentRepository StudentRepository
        {
            get { return _studentRepository = _studentRepository ?? new StudentRepository(_dbContext); }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

     

       
    }
}
