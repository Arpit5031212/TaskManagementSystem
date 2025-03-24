using TaskManagementSystem.Domain.Common;
using TaskStatus = TaskManagementSystem.Domain.Enums.TaskStatus;

namespace TaskManagementSystem.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public TaskStatus Status { get; set; } = TaskStatus.Pending;
        public DateTime DueDate { get; set; }

        // Foreign Keys
        public Guid ProjectId { get; set; }
        public required string AssignedUserId { get; set; }

        // References
        public Project? Project { get; set; }
        public ApplicationUser? AssignedUser { get; set; }
    }
}