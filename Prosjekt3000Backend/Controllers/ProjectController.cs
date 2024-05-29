using Microsoft.AspNetCore.Mvc;
using Prosjekt3000Backend.Models;

namespace Prosjekt3000Backend.Controllers;

public class ProjectController : Controller
{
    private readonly ProjectService _projectService;

    public ProjectController(ProjectService projectService) =>
        _projectService = projectService;

    [HttpGet]
    public async Task<List<ProjectModel>> Get() =>
        await _projectService.GetAsync();

    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<ProjectModel>> Get(string id)
    {
        var project = await _projectService.GetAsync(id);

        if (project is null)
        {
            return NotFound();
        }

        return project;
    }

    [HttpPost]
    public async Task<IActionResult> Post(ProjectModel newProject)
    {
        await _projectService.CreateAsync(newProject);

        return CreatedAtAction(nameof(Get), new { id = newProject.Id }, newProject);
    }

    [HttpPut("{id:length(24)}")]
    public async Task<IActionResult> Update(string id, ProjectModel updatedProject)
    {
        var project = await _projectService.GetAsync(id);

        if (project is null)
        {
            return NotFound();
        }

        updatedProject.Id = project.Id;

        await _projectService.UpdateAsync(id, updatedProject);

        return NoContent();
    }

    [HttpDelete("{id:length(24)}")]
    public async Task<IActionResult> Delete(string id)
    {
        var project = await _projectService.GetAsync(id);

        if (project is null)
        {
            return NotFound();
        }

        await _projectService.RemoveAsync(id);

        return NoContent();
    }
}