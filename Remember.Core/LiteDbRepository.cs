using LiteDB;
using System.Collections.Generic;

namespace Remember.Core
{
    public class LiteRepository<T>
    {
        protected LiteCollection<T> _collection;
        protected LiteRepository _repository;

        public LiteRepository(LiteRepository repository)
        {
            _repository = repository;

            var attr = typeof(T).GetAttribute<CollectionAttribute>();

            _collection = attr is null
                ? _repository.Database.GetCollection<T>()
                : _repository.Database.GetCollection<T>(attr.Name);


            // _collection = _db.GetCollection<T>(_attr.Name);
        }

            //public LiteDbRepository()
            //{
            //    //var db = new LiteDatabase(DependencyService.Get<IDataBaseAccess>().DatabasePath());
            //    //_collection = db.GetCollection<T>();
            //}

            public virtual T CreateItem(T item)
            {

                //var val0 = _repository.Insert(item, _attr.Name);
                //return item;

            var val = _collection.Insert(item);
            return item;
            }
            public virtual T UpdateItem(T item)
            {
                _collection.Update(item);
                return item;
            }
            public virtual T DeleteItemAsync(T item)
            {
                //var c = _collection.Delete(i => i.Equals(item));
                return item;
            }
            public virtual IEnumerable<T> ReadAllItems()
            {

                var all = _collection.FindAll();
                return new List<T>(all);
            }

    }
}
