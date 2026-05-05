Menu logic
Task list
Add task logic
Delete task logic
Mark complete logic
Validation
Search logic


Instead of this:

Program.cs does everything

We want this:

Program.cs              → Handles user interaction
TaskItem.cs             → Represents task data
ITaskService.cs         → Defines what task operations are available
TaskService.cs          → Contains task business logic

This is the start of backend architecture.


What You Will Build Today

You will refactor your Day 2 task manager into this structure:

TaskManagerConsole
 ┣ Program.cs
 ┣ Models
 ┃ ┗ TaskItem.cs
 ┣ Services
 ┃ ┣ ITaskService.cs
 ┃ ┗ TaskService.cs
 ┗ TaskManagerConsole.csproj

This is much closer to a real backend project.