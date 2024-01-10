
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private static readonly string[]
    Sumaries = new[]
    {

    };

    private readonly ILogger<TodoController> _logger;
}