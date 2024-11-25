namespace TodoApp;

public class TodoServiceTest
{
    [Fact]
    public void AddTaskTest()
    {
        TodoService service = new TodoService();

        service.AddTask("Test 1");

        var tasks = service.GetAllTasks();
        Assert.Single(tasks);
    }

    [Fact]
    public void DeleteTaskTest()
    {
        TodoService service = new TodoService();
        service.AddTask("Test 1");
        service.AddTask("Test 2");

        service.DeleteTask(1);
        service.DeleteTask(2);

        var tasks = service.GetAllTasks();
        Assert.Empty(tasks);
    }

    [Fact]
    public void GetAllTaskTest()
    {
        TodoService service = new TodoService();
        service.AddTask("Task 1");
        service.AddTask("Task 2");
        service.AddTask("Demo Task");

        var tasks = service.GetAllTasks();
        Assert.Equal(3,tasks.Count);
    }

    [Fact]
    public void GetTaskByIdTest()
    {
        TodoService service = new TodoService();
        service.AddTask("First Demo Task");

        var tasks = service.GetAllTasks();
        var task  = tasks.FirstOrDefault(t => t.Id == 1);

        if(task == null) throw new ArgumentException($"Task with ID {task.Id} not found.");
        Assert.NotNull(task);
        Assert.Equal(1, task.Id);
        Assert.Equal("First Demo Task", task.Title);
    }

    [Fact]
    public void MarkTaskAsCompletedTest()
    {
        TodoService service = new TodoService();
        service.AddTask("Mark Test");
        service.MarkTaskAsCompleted(1);

        var task = service.GetTaskById(1);

        Assert.Equal(true, task.IsCompleted);
    }

}