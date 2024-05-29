namespace Prosjekt3000Backend.Controllers;

public class ProjectStoreDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;

    public string ProjectCollectionName { get; set; } = null!;
}