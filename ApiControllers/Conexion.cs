using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System.Data;

[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult DinosaurioMongoDb(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDatabase("Chichagon");
        var collection = db.GetCollection<DinoMongo>("Dinosaurio");

        var lista = collection.Find(FilterDefinition<DinoMongo>.Empty).ToList();
        return Ok(lista);
    }
}