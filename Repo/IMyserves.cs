using System.Xml;
using System.Collections.Generic;
using Entities;

namespace webApp.interfaces.IMyserves
{
    public interface IMyService
    {
        IEnumerable<MyEntity> GetAll();
        MyEntity GetById(int id);
        void Add(MyEntity entity);
        void Update(MyEntity entity);
        void Delete(MyEntity entity);
    }
}