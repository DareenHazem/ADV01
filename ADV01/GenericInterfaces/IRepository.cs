using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01.GenericInterfaces
{
    internal interface IRepository<TEntity>
    {
        void AddPerson(TEntity item);
        List<TEntity> GetAll();
        void DeleteByID(int id);
        TEntity GetById(int id);
    }
}
