using Microsoft.AspNetCore.Mvc;

namespace ControllerApi;

[ApiController]
[Route("/api/controller")]
public class Api : ControllerBase{
    
    [HttpGet("test")]
    public IActionResult Test(){
        return Ok();
    }
}