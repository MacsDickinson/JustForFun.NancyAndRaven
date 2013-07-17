using System;
using System.Linq;
using JustForFun.NancyAndRaven.Models;
using Nancy;
using Nancy.ModelBinding;
using Raven.Client;

namespace JustForFun.NancyAndRaven.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule(IDocumentSession documentSession)
        {
            Get["/"] = parameters => View["Home", documentSession.Query<Quote>().OrderByDescending(x => x.DateCreated).ToList()];

            Post["/"] = paramters =>
                {
                    var model = this.Bind<Quote>();
                    model.DateCreated = DateTime.Now;

                    if (model.Content != null)
                    {
                        documentSession.Store(model);
                        documentSession.SaveChanges();
                    }

                    return Response.AsRedirect("/");
                };
        }
    }

    public class Foo
    {
        public string Bar { get; set; }
        public DateTime DateCreated { get; set; }
    }
}