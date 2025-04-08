namespace TaskDataAccess.Entity;

public class Assignment
{
    public long TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DeadLine { get; set; }
}
      
