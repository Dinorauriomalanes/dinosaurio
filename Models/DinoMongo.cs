using MongoDB.Bson.Serialization.Attributes;

public class DinoMongo{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? Id {get; set;}
    public string Dinosaurio {get; set;} = string.Empty;
    public decimal Peso {get; set;}
    public decimal Largo {get; set;}
    public decimal Altura {get; set;}
    public string Alimentacion {get; set;} = string.Empty;
    public string Era {get; set;} = string.Empty;
    public bool Valido {get; set;}
    public int AnioDescubrimiento {get; set;}
    public bool Volador {get; set;}
}