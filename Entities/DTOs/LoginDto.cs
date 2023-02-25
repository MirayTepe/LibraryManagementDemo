using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class LoginDto:IDto
    {
        public int AdminId { get; set; }
        public string AdminUserName { get; set; }

        public string Password { get; set; }
    }
}
