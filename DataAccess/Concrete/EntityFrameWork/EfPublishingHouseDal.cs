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
    public class EfPublishingHouseDal : IPublishingHouseDal
    {
        public void Add(PublishingHouse entity)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            
        }

        public void Delete(PublishingHouse entity)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public PublishingHouse Get(Expression<Func<PublishingHouse, bool>> filter)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                return context.Set<PublishingHouse>().SingleOrDefault(filter);
            }
        }

        public List<PublishingHouse> GetAll(Expression<Func<PublishingHouse, bool>> filter = null)
        {
            using (BookDatabasesContext context = new BookDatabasesContext())
            {
                return filter == null
                    ? context.Set<PublishingHouse>().ToList()
                    : context.Set<PublishingHouse>().Where(filter).ToList();

            }
        }

        public void Update(PublishingHouse entity)
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
