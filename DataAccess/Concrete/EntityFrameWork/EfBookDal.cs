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
    public class EfBookDal : IBookDal
    {
        public void Add(Book entity)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Book entity)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
           
        }

        public Book Get(Expression<Func<Book, bool>> filter)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                return context.Set<Book>().SingleOrDefault(filter);
            }
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                return filter == null? context.Set<Book>().ToList(): context.Set<Book>().Where(filter).ToList();

            }
        }

        public void Update(Book entity)
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
