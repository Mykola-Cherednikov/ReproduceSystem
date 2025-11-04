using MongoDB.Bson.Serialization.Attributes;
using ReproduceSystem.Domain.Entities.Body;

namespace ReproduceSystem.Domain.Entities
{
    public class Step
    {
        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("method")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public MethodType Method { get; set; }

        [BsonElement("headers")]
        public Dictionary<string, string> Headers { get; set; }

        [BsonElement("queryParams")]
        public Dictionary<string, string> QueryParams { get; set; }

        [BsonElement("contentType")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public ContentType ContentType { get; set; }

        [BsonElement("body")]
        [BsonIgnoreIfNull]
        public BodyContent? Body { get; set; }

        [BsonElement("outputFields")]
        [BsonIgnoreIfNull]
        public List<OutputField>? OutputFields { get; set; }

        [BsonElement("validations")]
        [BsonIgnoreIfNull]
        public List<Validation>? Validations { get; set; }
    }

    public enum MethodType
    {
        Get,
        Post,
        Put,
        Patch,
        Delete
    }

    public enum ContentType
    {
        None,
        FormData,
        Raw
    }
}
