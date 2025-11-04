using MongoDB.Bson.Serialization.Attributes;

namespace ReproduceSystem.Domain.Entities.Body
{
    public class RawBody : BodyContent
    {
        [BsonElement("text")]
        public string Text { get; set; }
    }
}
