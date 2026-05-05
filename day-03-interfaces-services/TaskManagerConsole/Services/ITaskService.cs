namespace TaskManagerConsole.Services;
using TaskManagerConsole.Models;

public interface ITaskService
{
    List<TaskItem> GetAllTasks();

    List<TaskItem> GetPendingTasks();

    TaskItem? GetTaskById(int id);

    TaskItem AddTask(string title);

    bool MarkTaskComplete(int id);

    bool UpdateTaskTitle(int id, string title);

    bool DeleteTask(int id);
}