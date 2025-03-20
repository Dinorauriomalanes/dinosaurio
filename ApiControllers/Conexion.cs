using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult DinosaurioMongoDb(){
        return Ok("Me estoy conectando a mongodb");
    }
}