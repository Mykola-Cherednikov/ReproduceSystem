using MongoDB.Bson.Serialization.Attributes;

namespace ReproduceSystem.Domain.Entities.Body
{
    public class FormData
    {
        [BsonElement("value")]
        public string Value { get; set; }

        [BsonElement("type")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public FormDataType Type { get; set; }
    }

    public enum FormDataType
    {
        Text,
        File
    }
}
