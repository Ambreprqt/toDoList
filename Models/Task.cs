using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace toDoList.Models;

public class Task
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }
}
