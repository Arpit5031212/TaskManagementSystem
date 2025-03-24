using TaskManagementSystem.Domain.Common;
using TaskManagementSystem.Domain.Enums;

namespace TaskManagementSystem.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Role Role { get; set; }

        // References
        public ICollection<Project>? Projects { get; set; }
        public ICollection<TaskItem>? AssignedTasks { get; set; }
    }
}