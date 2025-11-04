using MongoDB.Bson.Serialization.Attributes;

namespace ReproduceSystem.Domain.Entities
{
    public class Validation
    {
        [BsonElement("contentType")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public ValidationContentType ContentType { get; set; }

        [BsonElement("operation")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public ValidationOperation Operation { get; set; }

        [BsonElement("namespace")]
        [BsonIgnoreIfNull]
        public string? Namespace { get; set; }

        [BsonElement("value")]
        public string Value { get; set; }
    }

    public enum ValidationContentType
    {
        Text,
        Json,
        Xml
    }

    public enum ValidationOperation
    {
        Equal,
        Contains,
        More,
        Less
    }
}
