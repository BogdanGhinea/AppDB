using System;
using System.Collections.Generic;

#nullable disable

namespace AppDatenB.Models
{
    public partial class Article
    {
        public int Id { get; set; }
        public string Headline { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public string Author { get; set; }
    }
}
