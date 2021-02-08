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
            
            BookManager bookManager = new BookManager(new EfBookDal());
            List<Book> books = new List<Book>
            {
                   new Book { CategoryId = 4, BookName = "Satranç", BookAuthor = "Stefan Zwenıg", UnitPrice = 20, UnitInStock = 15, PublishingHouse = "Kırmızı Kedi" },
                   new Book { CategoryId = 4, BookName = "Satranç", BookAuthor = "Stefan Zwenıg", UnitPrice = 20, UnitInStock = 15, PublishingHouse = "Kırmızı Kedi" },
                   new Book { CategoryId = 4, BookName = "Satranç", BookAuthor = "Stefan Zwenıg", UnitPrice = 20, UnitInStock = 15, PublishingHouse = "Kırmızı Kedi" },
                   new Book { CategoryId = 4, BookName = "Satranç", BookAuthor = "Stefan Zwenıg", UnitPrice = 20, UnitInStock = 15, PublishingHouse = "Kırmızı Kedi" },
                   new Book { CategoryId = 4, BookName = "Satranç", BookAuthor = "Stefan Zwenıg", UnitPrice = 20, UnitInStock = 15, PublishingHouse = "Kırmızı Kedi" },
                   new Book { CategoryId = 4, BookName = "Satranç", BookAuthor = "Stefan Zwenıg", UnitPrice = 20, UnitInStock = 15, PublishingHouse = "Kırmızı Kedi" }
            };
            foreach (var book in books)
            {
                bookManager.Add(book);
            }
            
             
            
            
            

            //Console.WriteLine("Ürün Listesi");
            //BookManager bookManager = new BookManager(new EfBookDal());
            //foreach (var book in bookManager.GetAll())
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Ürün Bilgisi:" + "\n" +"Kitap Id: " +book.BookId + "\n" + book.BookName + "\n" + book.BookAuthor + "\n" + book.PublishingHouse + "\n" + book.UnitPrice + " $ ");
            //}

        }
    }
}
