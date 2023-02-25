using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Member : IEntity
    {
        public int MemberId { get; set; }
        public int UserId { get; set; }
        public string MemberNumber { get; set; }
        public string MemberPhoneNumber { get; set; }
        public string MemberAdress { get; set; }
    }
}
