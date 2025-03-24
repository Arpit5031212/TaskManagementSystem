using TaskManagementSystem.Application.Interfaces;
using TaskManagementSystem.Persistence.Contexts;

namespace TaskManagementSystem.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IUserRepository Users { get; }
        public IProjectRepository Projects { get; }
        public ITaskRepository Tasks { get; }

        public UnitOfWork(ApplicationDbContext context, IUserRepository users, IProjectRepository projects, ITaskRepository tasks)
        {
            _context = context;
            Users = users;
            Projects = projects;
            Tasks = tasks;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
