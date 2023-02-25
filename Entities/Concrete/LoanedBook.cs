using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class LoanedBook : IEntity
    {
        public int LoanedBookId { get; set; }
        public int MemberId { get; set; }
        public int BookId { get; set; }

        public DateTime DateLendingBook { get; set; }

        public DateTime DateRetrieveBook { get; set; }

        public DateTime DateLaonedBookProcessing { get; set; }

        public string LoanedBookNot { get; set; }

        public string LoanedBookDelivery { get; set; }


    }
}
