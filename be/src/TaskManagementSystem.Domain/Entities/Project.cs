using TaskManagementSystem.Domain.Common;

namespace TaskManagementSystem.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Foreign Key
        public string OwnerId { get; set; } = string.Empty;

        // References
        public ApplicationUser? Owner { get; set; }
        public ICollection<TaskItem>? Tasks { get; set; }
    }
}