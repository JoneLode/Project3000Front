using Microsoft.AspNetCore.Mvc;
using Prosjekt3000Backend.Models;
using System.Diagnostics;

namespace Prosjekt3000Backend.Controllers;

[ApiController]
[Route("/[controller]")]
public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	public IActionResult Index()
	{
		return View();
	}

	public IActionResult Privacy()
	{
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error()
	{
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}

	[HttpGet]
	public async Task<IActionResult> GetX()
	{
		return Ok("hei");
	}
}
