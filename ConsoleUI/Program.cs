using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {   
        static void Main(string[] args)
        {
            //GetAll();
            //TopluUrunEkleme(bookManager);
            //TekUrunEkleme(bookManager);
            //YayınEviEkleme(publishingHouseManager);
            //Guncelleme();
            //UrunSilme();

            BookManager bookManager = new BookManager(new EfBookDal());
            bookManager.GetBooksByPublishingHouseId(4);
            foreach (var book in bookManager.GetBooksByPublishingHouseId(4))
            {
                Console.WriteLine(book.BookId + " / "+ book.BookName);
            }

            

            PublishingHouseManager publishingHouseManager = new PublishingHouseManager(new EfPublishingHouseDal());
            publishingHouseManager.GetPublishingHouseById(5);
            foreach (var publishingHouse in publishingHouseManager.GetPublishingHouseById(5))
            {
                Console.WriteLine(publishingHouse.PublishingHouseId + " / " + publishingHouse.PublishingHouseName);
            }


            TypeOfBookManager typeOfBookManager = new TypeOfBookManager(new EfTypeOfBookDal());

            typeOfBookManager.Add(new TypeOfBook {TypeOfBookName ="Öykü"});
            


        }

        private static void UrunSilme()
        {
            BookManager bookManager = new BookManager(new EfBookDal());
            bookManager.Delete(new Book { BookId = 1003, CategoryId = 5, BookName = "Eski Dünya", BookAuthor = "Sabahattin Ali", UnitPrice = 19, UnitInStock = 10, PublishingHouse = "YKY", BookPublishingHouseId = 5, BookTypeOfBookId = 1 });
        }


        private static void Guncelleme()
        {
            BookManager bookManager = new BookManager(new EfBookDal());
            bookManager.Update(new Book { BookId = 1003, CategoryId = 5, BookName = "Eski Dünya", BookAuthor = "Sabahattin Ali", UnitPrice = 19, UnitInStock = 10, PublishingHouse = "YKY", BookPublishingHouseId = 5, BookTypeOfBookId = 1 });
            foreach (var book in bookManager.GetAll())
            {
                Console.WriteLine(book.BookName);
            }
        }

        private static void GetAll()
        {
            BookManager bookManager = new BookManager(new EfBookDal());
            foreach (var book in bookManager.GetAll())
            {
                Console.WriteLine(book.BookName + "  /   " + book.BookAuthor);
            }
        }

        private static void TekUrunEkleme(BookManager bookManager)
        {
            bookManager.Add(new Book { BookName = "İslam Tarihi-1", BookAuthor = "Adem Apak", PublishingHouse = "Ensar Yayınları", BookPublishingHouseId = 8, BookTypeOfBookId = 9, CategoryId = 5, UnitInStock = 12, UnitPrice = 29 });

            foreach (var book in bookManager.GetAll())
            {
                Console.WriteLine(book.BookName);
            }
        }

        private static void YayınEviEkleme(PublishingHouseManager publishingHouseManager)
        {
            List<PublishingHouse> publishingHouses = new List<PublishingHouse>
            {
                  new PublishingHouse{PublishingHouseId = 5, PublishingHouseName = "YKY"}
            };
            foreach (var publishingHouse in publishingHouses)
            {
                publishingHouseManager.Add(publishingHouse);
            }
        }

        private static void TopluUrunEkleme(BookManager bookManager)
        {
            List<Book> books = new List<Book>
            {
                   new Book{ CategoryId = 5, BookName = "Yeni Dünya", BookAuthor ="Sabahattin Ali", UnitPrice =19, UnitInStock =10, PublishingHouse = "YKY", BookPublishingHouseId = 5, BookTypeOfBookId =1},
                   new Book{ CategoryId = 4, BookName = "Satranç", BookAuthor ="Stefan Zwenıg", UnitPrice =20, UnitInStock =15, PublishingHouse = "Kırmızı Kedi", BookPublishingHouseId = 4, BookTypeOfBookId = 2},
                   new Book{ CategoryId = 3, BookName = "İçimizdeki Şeytan", BookAuthor ="Sabahattin Ali", UnitPrice =25, UnitInStock =50, PublishingHouse = "YKY", BookPublishingHouseId = 5, BookTypeOfBookId = 3},
                   new Book{ CategoryId = 2, BookName = "Milenya'ya Mektuplar", BookAuthor ="Franz Kafka", UnitPrice =27, UnitInStock =18, PublishingHouse = "MaviÇatı", BookPublishingHouseId = 3, BookTypeOfBookId = 4},
                   new Book{ CategoryId = 1, BookName = "Şanzelize Düğün Salonu", BookAuthor ="Tarık Tufan", UnitPrice =29, UnitInStock =46, PublishingHouse = "Profil Kitap", BookPublishingHouseId =2, BookTypeOfBookId =5}

            };
            foreach (var book in books)
            {
                bookManager.Add(book);
            }
        }
    }
}
