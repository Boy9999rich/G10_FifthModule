using TaskRepository.Settings;

namespace Task.Server.Configuration;

public static class DatabaseConfiguration
{
    public static void ConfigureDataBase(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");
        var sqlConnectionAdo = new SqlDbConnConnectioninAdoNet(connectionString);
        builder.Services.AddSingleton<SqlDbConnConnectioninAdoNet>(sqlConnectionAdo);
    }
}
