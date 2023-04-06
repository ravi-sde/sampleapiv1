using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    

    [HttpGet]
    public IActionResult Get()
    {
        var persons = new string[]{
            "Mohan",
            "Himanshu",
            "Abhishek",
            "Ram",
            "Ravi",
            "Jayme",
            "Wiqas"
        };
        return Ok(persons);
    }
}
