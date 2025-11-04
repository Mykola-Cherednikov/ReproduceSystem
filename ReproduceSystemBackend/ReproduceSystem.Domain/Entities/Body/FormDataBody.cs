using MongoDB.Bson.Serialization.Attributes;

namespace ReproduceSystem.Domain.Entities.Body
{
    public class FormDataBody : BodyContent
    {
        [BsonElement("formData")]
        public Dictionary<string, FormData> FormData { get; set; }
    }
}
