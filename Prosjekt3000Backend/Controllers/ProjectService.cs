using Prosjekt3000Backend.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;



namespace Prosjekt3000Backend.Controllers;

public class ProjectService
{
  private readonly IMongoCollection<ProjectModel> _projectsCollection;

    public ProjectService(
        IOptions<BookStoreDatabaseSettings> bookStoreDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            bookStoreDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            bookStoreDatabaseSettings.Value.DatabaseName);

        _projectsCollection = mongoDatabase.GetCollection<ProjectModel>(
            bookStoreDatabaseSettings.Value.BooksCollectionName);
    }

    public async Task<List<ProjectModel>> GetAsync() =>
        await _projectsCollection.Find(_ => true).ToListAsync();

    public async Task<ProjectModel?> GetAsync(string id) =>
        await _projectsCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(ProjectModel newBook) =>
        await _projectsCollection.InsertOneAsync(newBook);

    public async Task UpdateAsync(string id, ProjectModel updatedBook) =>
        await _projectsCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

    public async Task RemoveAsync(string id) =>
        await _projectsCollection.DeleteOneAsync(x => x.Id == id);
}