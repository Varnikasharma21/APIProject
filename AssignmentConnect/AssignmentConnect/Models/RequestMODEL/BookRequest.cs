using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentConnect.Models.RequestMODEL
{
    public class BookRequest
    {
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookSeller { get; set; }
        public long? BookCode { get; set; }
        public int? TotalPages { get; set; }
        public string BookPrice { get; set; }
    }
}
