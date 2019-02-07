using LiteDB;

namespace Remember.Core
{
    [Collection("cards2")]
    public class CardModel
    {
        //[BsonId]
        public int Id { get; set; }

        //[BsonIgnore]
        public string Origin { get; set; }

        //[BsonIgnore]
        public string Transcription { get; set; }

        //[BsonIgnore]
        public string Translation { get; set; }

        public BsonDocument BDoc { get; set; }
    }
}
