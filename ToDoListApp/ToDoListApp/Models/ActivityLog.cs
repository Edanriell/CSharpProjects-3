using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Models;

public class ActivityLog
{
    public ActivityLog()
    {
        Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }
    public string EntityId { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public string Property { get; set; } = string.Empty;
    public string OldValue { get; set; } = string.Empty;
    public string NewValue { get; set; } = string.Empty;
}
