using TaskDataAccess.Entity;

namespace TaskRepository.Services
{
    public interface ITaskRepo
    {
        Task<long> AddTaskAsync(Assignment task);
        Task DeleteTaskAsync(long TaskId);
        Task UpdateTaskAsync(Assignment assignment);
        Task<List<Assignment>> GetAllTasksAsync();
    }
}