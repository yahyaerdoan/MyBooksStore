using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TypeOfBookManager : ITypeOfBookService
    {
        ITypeOfBookDal _typeOfBookDal;
        public TypeOfBookManager(ITypeOfBookDal typeOfBookDal)
        {
            _typeOfBookDal = typeOfBookDal;
        }
        public void Add(TypeOfBook typeOfBook)
        {
            _typeOfBookDal.Add(typeOfBook);
            Console.WriteLine("Tür eklendi.");
        }

        public void Delete(TypeOfBook typeOfBook)
        {
            _typeOfBookDal.Delete(typeOfBook);
            Console.WriteLine("Tür silindi.");
        }

        public List<TypeOfBook> GetAll()
        {
            return _typeOfBookDal.GetAll();           
        }

        public List<TypeOfBook> GetTypeOfBooksById(int id)
        {
            return _typeOfBookDal.GetAll(t => t.TypeOfBookId== id);
        }

        public void Update(TypeOfBook typeOfBook)
        {
            _typeOfBookDal.Update(typeOfBook);
            Console.WriteLine("Tür güncellendi.");
        }
    }
}
