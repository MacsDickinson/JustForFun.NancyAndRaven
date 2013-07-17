using Raven.Client.Embedded;

namespace JustForFun.NancyAndRaven.Raven
{
    public class RavenSessionProvider
    {
        private static EmbeddableDocumentStore _documentStore;

        public bool SessionInitialized { get; set; }

        public static EmbeddableDocumentStore DocumentStore
        {
            get { return (_documentStore ?? (_documentStore = CreateDocumentStore())); }
        }

        private static EmbeddableDocumentStore CreateDocumentStore()
        {
            var store = new EmbeddableDocumentStore
                {
                    ConnectionStringName = "RavenHQ"
                };

            store.Initialize();

            return store;
        }
    }
}