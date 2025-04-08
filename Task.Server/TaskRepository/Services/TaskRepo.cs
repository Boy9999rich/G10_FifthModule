using Microsoft.Data.SqlClient;
using System.Data;
using TaskDataAccess.Entity;
using TaskRepository.Settings;

namespace TaskRepository.Services;

public class TaskRepo : ITaskRepo
{
    private readonly string ConnectionString;
    public TaskRepo(SqlDbConnConnectioninAdoNet sqlDbConnConnectioninAdoNet)
    {
        ConnectionString = sqlDbConnConnectioninAdoNet.ConnectionString;
    }
    public async Task<long> AddTaskAsync(Assignment task)
    {
        using (SqlConnection conn = new SqlConnection(ConnectionString))
        {
            await conn.OpenAsync();
            using (SqlCommand cmd = new SqlCommand("", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

            }
        }
    }

    private CommandType CommandType()
    {
        throw new NotImplementedException();
    }

    public Task DeleteTaskAsync(long TaskId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Assignment>> GetAllTasksAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateTaskAsync(Assignment assignment)
    {
        throw new NotImplementedException();
    }
}
