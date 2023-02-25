using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class Book:IEntity
     {
        public int BookId { get; set; }
        public int CategoryId { get; set; }
        public string BookName { get; set; }    
        
        public int BookCount { get; set; }
        public string BookAuthor { get; set; }
        public string BookNumberOfPage { get; set; }
        public string BookLanguage { get; set; }

        public string BookPublisher { get; set; }
        public string BookDescription { get; set; }

    }
}
