using System.ComponentModel.DataAnnotations;

namespace task_manager_project.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }

        public string Priority { get; set; }   // Low, Medium, High

        public string Status { get; set; } = "Pending"; // Default
    }
}
