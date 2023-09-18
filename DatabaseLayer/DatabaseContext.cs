using Microsoft.EntityFrameworkCore;

namespace DatabaseLayer.Models;

//Scaffold-DbContext "Server=(localdb)\MSSQLLocalDB;Database=database;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -NoOnConfiguring -force
public partial class DatabaseContext
{
    public DatabaseContext()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var dbFile = Path.GetFullPath(@"..\..\..\..\database.mdf");

        optionsBuilder.UseSqlServer($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbFile};Integrated Security=True");
    }
}
