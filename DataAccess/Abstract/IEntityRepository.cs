using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> Filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


        //Expression metodu veri filitrelemeyi sağlar dolayısıyla aşağıdaki categori metoduna ihtiyacımız kalmaz
       // Ürünleri Kategoriye göre sıralamamızı sağlar

        //List<T> GetAllByCategory(int categoryId);
        //List<T> Add();
    }
}
