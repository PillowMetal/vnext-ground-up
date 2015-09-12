using Microsoft.Data.Entity;

public class GroundUpDbContext : DbContext
{
    public DbSet<TodoItem> Todos {get; set;}

    protected override void OnConfiguring(DbContextOptions builder)
    {
        builder.UseSqlServer(@"Data Source=contractor\sqlexpress;Initial Catalog=test;Integrated Security=True;");
    }
}

public class TodoItem
{
    public int Id {get; set;}
    public string Description {get; set;}
}
