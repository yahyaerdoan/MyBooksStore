using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPublishingHouseService
    {
        List<PublishingHouse> GetAll();

        List<PublishingHouse> GetPublishingHouseById(int id);

        void Add(PublishingHouse publishingHouse);
        void Delete(PublishingHouse publishingHouse);
        void Update(PublishingHouse publishingHouse);
    }
}
