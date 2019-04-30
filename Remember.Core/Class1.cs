using LiteDB;
using System.Linq;

namespace Remember.Core
{

    public class DbHelper
    {
        public void Create()
        {
            // Open database (or create if doesn't exist)
            using (var db = new LiteDatabase(@"MyData.db"))
            {

                var t = new LiteRepository(@"MyData.db");

                var r = t.Query<CardModel>().Where(b => b.Origin == "Dog") // conditional filter
                .ToList();

                // Get customer collection
                var col = db.GetCollection<CardModel>("cards");

                // Create your new customer instance
                var card = new CardModel
                {
                    //Id = ObjectId.NewObjectId(),
                    Origin = "Dog",
                    Transcription = "Dog",
                    Translation = "Собака"
                };

                // Create unique index in Name field
                //col.EnsureIndex(x => x.Origin, true);

                // Insert new customer document (Id will be auto-incremented)
                // col.Insert(card);

                // Update a document inside a collection
                //card.Transcription = "Doog";

                //                col.Update(card);

                // Use LINQ to query documents (with no index)
                // var results = col.Find(x => x.Origin == "Dog");
            }
        }

        public CardModel Find()
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<CardModel>("cards");

                var results = col.Find(x => x.Origin == "Dog").FirstOrDefault();

                return results;
            }
        }
    }
}
