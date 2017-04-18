using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoDashboard.Web.ViewModels
{
    public class MemberViewModel
    {
        public long MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MemberType { get; set; }
        public string TaxId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
