using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

       
        public void Add(Book book)
        {
            if (book.UnitPrice>0)
            {
                _bookDal.Add(book);
                Console.WriteLine("Kitap eklendi.");
            }
            else
            {
                Console.WriteLine("Fiyat 0'dan büyük olmalıdır!");
            }
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
            Console.WriteLine("Kitap silindi.");

        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetBooksByPublishingHouseId(int id)
        {
            return _bookDal.GetAll(b => b.BookPublishingHouseId== id);
        }

        public List<Book> GetBooksByTypeOfBookId(int id)
        {
            return _bookDal.GetAll(b => b.BookTypeOfBookId == id);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
            Console.WriteLine("Kitap güncellendi.");
        }
    } 
}
