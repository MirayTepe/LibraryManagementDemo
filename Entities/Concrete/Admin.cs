using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public  class Admin:IEntity
    {
       
        public int AdminId { get; set; }
        public int UserId { get; set; }
        public string AdminUserName { get; set; }

       


    }
}
