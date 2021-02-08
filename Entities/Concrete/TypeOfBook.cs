using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete 
{
    public class TypeOfBook : IEntity
    {
        public int TypeOfBookId { get; set; }
        public string TypeOfBookName { get; set; }
      
    }
}
