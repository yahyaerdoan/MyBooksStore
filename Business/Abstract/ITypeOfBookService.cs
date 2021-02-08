using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITypeOfBookService
    {
        List<TypeOfBook> GetAll();
        List<TypeOfBook> GetTypeOfBooksById(int id);

        void Add(TypeOfBook typeOfBook);
        void Delete(TypeOfBook typeOfBook);
        void Update(TypeOfBook typeOfBook);
    }
}
