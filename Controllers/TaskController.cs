using Microsoft.AspNetCore.Mvc;
using Task = toDoList.Models.Task;

namespace toDoList.Controllers;

[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    private readonly List<Task> _tasks = new List<Task>();

    [HttpGet]
    public IEnumerable<Task> GetTasks()
    {
        return _tasks;
    }

    [HttpPost]
    public ActionResult<Task> CreateTask(Task task)
    {
        task.Id = _tasks.Count + 1;
        _tasks.Add(task);
        return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
    }
}
