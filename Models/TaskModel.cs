using System;
using System.ComponentModel.DataAnnotations;

namespace Task_Management_Oritso_Assignment.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public string? Description { get; set; }

        [Required(ErrorMessage = "Due Date is required")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        public string? Remarks { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public DateTime LastUpdatedOn { get; set; } = DateTime.Now;

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public string LastUpdatedBy { get; set; }
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
