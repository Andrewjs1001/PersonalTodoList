using System;
using System.Collections.Generic;

namespace WebApplication4.Models
{
    public partial class TaskModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Status { get; set; }
        public int Importance { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateCompleted { get; set; }
        public bool DidYouLearn { get; set; }
    }
}
