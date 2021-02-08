using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public  interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetCategoriesById(int id);

        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);

    }
}
