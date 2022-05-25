using System;
using System.Collections.Generic;

namespace AssignmentConnect.Models
{
    public partial class Details
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public string BookSeller { get; set; }
        public long? BookCode { get; set; }
        public int? TotalPages { get; set; }
        public string BookPrice { get; set; }
        //public int Detailsid { get; internal set; }
        //public bool Details_Id { get; internal set; }
    }
}
