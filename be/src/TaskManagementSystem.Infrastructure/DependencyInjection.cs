using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementSystem.Persistence.Contexts;
using Microsoft.Extensions.Configuration;
using TaskManagementSystem.Application.Interfaces;
using TaskManagementSystem.Persistence.Repositories;
using TaskManagementSystem.Persistence;
using Microsoft.AspNetCore.Identity;
using TaskManagementSystem.Domain.Entities;

namespace TaskManagementSystem.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection Addinfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Database conneciton
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("TaskManagementSystem.Persistence"))); // Specify migrations assembly

            //Identity Configuration
            services.AddIdentity<ApplicationUser, IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            // Register Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

    }
}