using MongoDB.Bson.Serialization.Attributes;

namespace ReproduceSystem.Domain.Entities
{
    public class OutputField
    {
        [BsonElement("namespace")]
        public string Namespace { get; set; } = string.Empty;

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;

        [BsonElement("type")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public OutputFieldType Type { get; set; }
    }

    public enum OutputFieldType
    {
        Local,
        Global
    }
}
