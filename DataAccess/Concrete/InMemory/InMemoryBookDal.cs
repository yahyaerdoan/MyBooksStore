using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBookDal : IBookDal
    {
        List<Book> _book;
        public InMemoryBookDal()
        {
            _book = new List<Book> 
            { 
                new Book{BookId = 1, CategoryId = 5, BookName = "Yeni Dünya", BookAuthor ="Sabahattin Ali", UnitPrice =19, UnitInStock =10, PublishingHouse = "YKY"},
                new Book{BookId = 2, CategoryId = 4, BookName = "Satranç", BookAuthor ="Stefan Zwenıg", UnitPrice =20, UnitInStock =15, PublishingHouse = "Kırmızı Kedi"},
                new Book{BookId = 3, CategoryId = 3, BookName = "İçimizdeki Şeytan", BookAuthor ="Sabahattin Ali", UnitPrice =25, UnitInStock =50, PublishingHouse = "YKY"},
                new Book{BookId = 4, CategoryId = 2, BookName = "Milenya'ya Mektuplar", BookAuthor ="Franz Kafka", UnitPrice =27, UnitInStock =18, PublishingHouse = "MaviÇatı"},
                new Book{BookId = 5, CategoryId = 1, BookName = "Şanzelize Düğün Salonu", BookAuthor ="Tarık Tufan", UnitPrice =29, UnitInStock =46, PublishingHouse = "Profil Kitap"},

            };
        }
        public void Add(Book book)
        {
            _book.Add(book);
        }
               

        public void Delete(Book book)     //LAMDA takma isim verme b=>b.
        {
            Book bookToDelete = _book.SingleOrDefault(b=>b.BookId == book.BookId);
            _book.Remove(bookToDelete);
        }

        public Book Get(Expression<Func<Book, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return _book;
        }

        public List<Book> GetAll(Expression<Func<Book, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllByCategory(int categoryId)
        {
            return _book.Where(b => b.CategoryId == categoryId).ToList();
                  
        }

        public void Update(Book book)
        {
            Book bookToUpdate = _book.SingleOrDefault(b => b.BookId == book.BookId);
            bookToUpdate.BookName = book.BookName;
            bookToUpdate.BookAuthor = book.BookAuthor;
            bookToUpdate.CategoryId = book.CategoryId;
            bookToUpdate.UnitInStock = book.UnitInStock;
            bookToUpdate.UnitPrice = book.UnitPrice;

        }

       

        
    }
}
