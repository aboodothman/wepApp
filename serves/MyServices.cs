using Entities;
using static services.MyServices;
using webApp.interfaces.IMyserves;

namespace services
{
    public class MyServices
    {

        public class MyService : IMyService
        {
            private readonly List<MyEntity> _entities = new List<MyEntity>();

            public void Add(MyEntity entity)
            {
                _entities.Add(entity);
            }

            public void Delete(MyEntity entity)
            {
                _entities.Remove(entity);
            }

            public IEnumerable<MyEntity> GetAll()
            {
                return _entities;
            }

            public MyEntity GetById(int id)
            {
                return _entities.Find(e => e.Id == id);
            }

            public void Update(MyEntity entity)
            {
                var index = _entities.FindIndex(e => e.Id == entity.Id);
                _entities[index] = entity;
            }
        }
    }
   pu
}