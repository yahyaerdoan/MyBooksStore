using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfTypeOfBookDal : ITypeOfBookDal
    {
        public void Add(TypeOfBook entity)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TypeOfBook entity)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }       
        }

        public TypeOfBook Get(Expression<Func<TypeOfBook, bool>> filter)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                return context.Set<TypeOfBook>().SingleOrDefault(filter);
            }
        }

        public List<TypeOfBook> GetAll(Expression<Func<TypeOfBook, bool>> filter = null)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                return filter == null
                    ? context.Set<TypeOfBook>().ToList()
                    : context.Set<TypeOfBook>().Where(filter).ToList();
            }
        }

        public void Update(TypeOfBook entity)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
