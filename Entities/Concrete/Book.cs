using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Book : IEntity
   {
        public int? BookId { get; set; }
        public int CategoryId { get; set; }
        public int BookTypeOfBookId { get; set; }
        public int BookPublishingHouseId { get; set; }
        public string BookAuthor { get; set; }
        public string BookName { get; set; }
        public string PublishingHouse { get; set; }
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
   }
}
