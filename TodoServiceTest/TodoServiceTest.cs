namespace TodoApp;

public class TodoServiceTest
{
    [Fact]
    public void AddTaskTest()
    {
        TodoService service = new TodoService();

        service.AddTask("Test 1");
        Assert.Single(GetAllTask);
    }

    [[Fact]
    public void DeleteTaskTest()
    {

        // Given
        
        // When
    
        // Then
    }]
}