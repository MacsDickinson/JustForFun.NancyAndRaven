using System;

namespace JustForFun.NancyAndRaven.Models
{
    public class Quote
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string Source { get; set; }
        public DateTime DateCreated { get; set; }
    }
}