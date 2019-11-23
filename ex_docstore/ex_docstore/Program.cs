using System;
using System.Collections.Generic;

namespace ex_docstore
{
    public class DocumentStore
    {
        private readonly List<string> documents = new List<string>();
        private readonly int capacity;

        public DocumentStore(int capacity)
        {
            this.capacity = capacity;
        }

        public int Capacity { get { return capacity; } }

        public IEnumerable<string> Documents { get { return documents.ToArray(); } }

        public void AddDocument(string document)
        {
            if (documents.Count >= capacity)
                throw new InvalidOperationException();

            documents.Add(document);
        }

        public override string ToString()
        {
            return $"Document store: {documents.Count}/{capacity}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DocumentStore documentStore = new DocumentStore(2);
            documentStore.AddDocument("item");
            //documentStore.AddDocument("item2");
            var items = documentStore.Documents;

            
            Console.WriteLine(documentStore);
        }
    }
}
