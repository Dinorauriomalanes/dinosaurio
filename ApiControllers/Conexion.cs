using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("conexion")]
public class Conexion : Controller {
    [HttpGet("mongo")]
    public IActionResult DinosaurioMongoDb(){
        MongoClient client = MongoClient(CadenasConexion.MONGO_DB);
        var db = client.GetDataBase("Chichagon");
        var collection = db.GetCollection<DinoMongo>("Dinosaurio");

        var lista = collection.Find(FilterDefinition<Dinongo>.Empty).ToList();
        return Ok(lista);
    }
}