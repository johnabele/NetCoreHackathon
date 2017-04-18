using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoMemberService.Data.Model
{
    public class Member
    {
        public long MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberType { get; set; }
        public string TaxId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
