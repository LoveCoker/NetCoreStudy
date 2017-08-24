using System;
using System.Collections.Generic;

namespace WebCoreWithMSSQL.Models
{
    public partial class Book
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Isbn { get; set; }
        public int WordsCount { get; set; }
        public decimal UnitPrice { get; set; }
        public string ContentDescription { get; set; }
        public string AurhorDescription { get; set; }
        public string EditorComment { get; set; }
        public string Toc { get; set; }
    }
}
