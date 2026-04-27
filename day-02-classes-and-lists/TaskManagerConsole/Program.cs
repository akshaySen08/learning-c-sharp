List<TaskItem> tasks = []; // List is Array in JS

TaskItem task1 = new TaskItem(1, "Go for groceries");
TaskItem task2 = new TaskItem(2, "Call Kiran");
TaskItem task3 = new TaskItem(3, "Send that email");
TaskItem task4 = new TaskItem(4, "Go for walk");
TaskItem task5 = new TaskItem(5, "Go to dinner");

tasks.Add(task1);
tasks.Add(task2);
tasks.Add(task3);
tasks.Add(task4);
tasks.Add(task5);


TaskItem? selectedTask = tasks.FirstOrDefault(task => task.Id == 2);

if (selectedTask != null)
{
    Console.WriteLine($"Task Found - {selectedTask.Title}");
}
else
{
    Console.WriteLine($"Task not found.");
}

// 1. View all tasks
// 2. Add task
// 3. Mark task complete
// 4. Delete task
// 5. Exit

int nextid = 4;
bool isRunning = true;
int taskCount = tasks.Count;

while (isRunning)
{
    Console.WriteLine();
    Console.WriteLine("===== Task Manager =====");
    Console.WriteLine("1. View all tasks");
    Console.WriteLine("2. Add task");
    Console.WriteLine("3. Mark task complete");
    Console.WriteLine("4. Delete task");
    Console.WriteLine("5. Update task title");
    Console.WriteLine("6. Show only pending tasks");
    Console.WriteLine("7. Exit");
    Console.WriteLine("Choose an option:");
    string? choice = Console.ReadLine();

    switch (Convert.ToInt32(choice))
    {
        case 1:
            ShowAllTasks();
            break;
        case 2:
            AddNewTask();
            break;
        case 3:
            MarkTaskCompleted();
            break;
        case 4:
            DeleteTask();
            break;
        case 5:
            UpdateTaskTitle();
            break;
        case 6:
            List<TaskItem> pendingTasks = PendingTasks();
            foreach (TaskItem taskitem in pendingTasks)
            {
                Console.WriteLine($"{taskitem.Id} - {taskitem.Title}");
            }
            break;
        case 7:
            isRunning = false;
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Invalid option. Please choose 1-5.");
            break;
    }

}

void ShowAllTasks()
{
    if (taskCount > 0)
    {
        foreach (TaskItem task in tasks)
        {
            Console.WriteLine($"{task.Id}. - {task.Title} - Completed: {task.IsCompleted}");
        }
    }
    else
    {
        Console.WriteLine("Task list is empty");
    }
}

void AddNewTask()
{
    Console.WriteLine("Enter task title -");
    string? taskTitle = Console.ReadLine();

    TaskItem? newTaskItem = new TaskItem(nextid, taskTitle);
    tasks.Add(newTaskItem);

    Console.WriteLine("Task Added Successfully");
    nextid++;
}

void MarkTaskCompleted()
{
    Console.WriteLine("Enter which task you want to mark complete -");
    int taskId = Convert.ToInt32(Console.ReadLine());
    tasks.FirstOrDefault(task => task.Id == taskId).MarkCompleted();
    Console.WriteLine("Task marked completed successfully");
}

void DeleteTask()
{
    Console.WriteLine("Enter the task id you want to delete");
    int taskIdToDelete = Convert.ToInt32(Console.ReadLine());

    TaskItem? taskToDelete = tasks.Find(task => task.Id == taskIdToDelete);

    if (taskToDelete == null)
    {
        Console.WriteLine("Task not found enter correct task id");
        return;
    }
    tasks.Remove(taskToDelete);
    Console.WriteLine("Task Deleted Successfully");
}

void UpdateTaskTitle()
{
    Console.WriteLine("Enter the id of task you want to update the title of - ");
    int taskIdToUpdate = Convert.ToInt32(Console.ReadLine());

    TaskItem? taskToUpdate = tasks.Find(task => task.Id == taskIdToUpdate);

    if (taskToUpdate == null)
    {
        Console.WriteLine("Task not found, please try a correct task id");
        return;
    }

    Console.WriteLine($"Enter the new title of task - {taskToUpdate.Title}");
    string? newTaskTitle = Console.ReadLine();
    taskToUpdate.Title = newTaskTitle;

    Console.WriteLine("Task updated successfully");

}


List<TaskItem> PendingTasks()
{
    return [.. tasks.Where(task => !task.IsCompleted)];
}
