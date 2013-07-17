using System.Collections.Generic;
using JustForFun.NancyAndRaven.Models;

namespace JustForFun.NancyAndRaven.ViewModels
{
    public class DefaultViewModel
    {
        public List<Quote> Quotes { get; set; }
        public Quote NewQuote { get; set; }
    }
}