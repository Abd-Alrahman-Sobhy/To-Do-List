using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models
{
    public class ToDoTask
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime? DeadLine { get; set; }

        public string UserId { get; set; } = string.Empty;

        public User? user { get; set; }
    }
}
