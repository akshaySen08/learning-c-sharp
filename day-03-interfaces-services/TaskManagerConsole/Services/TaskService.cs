using TaskManagerConsole.Models;

namespace TaskManagerConsole.Services;

public class TaskService: ITaskService
{
    private readonly List<TaskItem> _tasks = new List<TaskItem>();
    
}