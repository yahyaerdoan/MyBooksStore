using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PublishingHouseManager : IPublishingHouseService
    {
        IPublishingHouseDal _publishingHouseDal;
        public PublishingHouseManager(IPublishingHouseDal publishingHouseDal)
        {
            _publishingHouseDal = publishingHouseDal;
        }
        public void Add(PublishingHouse publishingHouse)
        {
            if (publishingHouse.PublishingHouseName.Length > 2)
            {
                _publishingHouseDal.Add(publishingHouse);
                Console.WriteLine("Yayınevi başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine($"İsim minimum iki karekter olmalıdır! Girdiğiniz yayınevi adı : {publishingHouse.PublishingHouseName}");
            }
        }

        public void Delete(PublishingHouse publishingHouse)
        {
            _publishingHouseDal.Delete(publishingHouse);
            Console.WriteLine("Yayınevi başarıyla silindi.");
        }

        public List<PublishingHouse> GetAll()
        {
            return _publishingHouseDal.GetAll();
        }

        public List<PublishingHouse> GetPublishingHouseById(int id)
        {
            return _publishingHouseDal.GetAll(p => p.PublishingHouseId == id);

        }

        public void Update(PublishingHouse publishingHouse)
        {
            if (publishingHouse.PublishingHouseName.Length >= 2)
            {
                _publishingHouseDal.Update(publishingHouse);
                Console.WriteLine("Yayınevi başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine($"İsim minimum iki karekter olmalıdır! Girdiğiniz yayınevi adı : {publishingHouse.PublishingHouseName}");
            }
        }

       
    }
}
