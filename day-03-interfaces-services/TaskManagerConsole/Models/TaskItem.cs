namespace TaskManagerConsole.Models;

public class TaskItem
{
    public int Id { get; set; }

    public string Title { get; set; }

    public bool IsCompleted { get; set; } = false;

    public TaskItem(int id, string title)
    {
        Id = id;
        Title = title;
        IsCompleted = false;
        CreatedAt = DateTime.Now;
    }

    public void MarkCompleted() => IsCompleted = true;

    public void UpdateTitle(string newTitle)
    {
        Title = newTitle;
    }

}