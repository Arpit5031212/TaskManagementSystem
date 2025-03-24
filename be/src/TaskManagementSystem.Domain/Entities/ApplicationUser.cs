using Microsoft.AspNetCore.Identity;

namespace TaskManagementSystem.Domain.Entities
{

    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;

        // References
        public ICollection<Project>? Projects { get; set; }
        public ICollection<TaskItem>? AssignedTasks { get; set; }
    }
}
