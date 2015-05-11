using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace WorldsSmallestBookstore.Client
{
    public class ServiceClient
    {
        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            //public int AuthorID { get; set; }
            public Author Author { get; set; }
            //public int PublisherID { get; set; }
            public Publisher Publisher { get; set; }

        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string LastName { get; set; }
            public string FirstName { get; set; }
        }
        public class Publisher
        {
            public int PublisherID { get; set; }
            public string Name { get; set; }
            public string City { get; set; }
        }

        private TResult SafeHttp<TResult>(Func<HttpClient, TResult> action)
        {
            using (var client = new HttpClient())
            {
                return action(client);
            }
        }
        public IEnumerable<Book> GetBooks()
        {
            return GetCollection<Book>("api/books");
        }

        private IEnumerable<TResult> GetCollection<TResult>(string requestUri)
        {
            return SafeHttp(client =>
            {
                Setup(client);
                var response = MakeCall(client, requestUri);
                var retVal = ProcessResponseCollection<TResult>(response);
                return retVal;
            });
        }

        private static IEnumerable<TEntity> ProcessResponseCollection<TEntity>(HttpResponseMessage response)
        {
            var retVal = response.Content.ReadAsAsync<IEnumerable<TEntity>>().Result;
            return retVal;
        }

        private static HttpResponseMessage MakeCall(HttpClient client, string requestUri)
        {
            HttpResponseMessage response = client.GetAsync(requestUri).Result;
            if (!response.IsSuccessStatusCode) throw new Exception();
            return response;
        }

        private static void Setup(HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:4640/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public IEnumerable<Author> GetAuthors()
        {
            return GetCollection<Author>("api/authors");
        }

        public IEnumerable<Publisher> GetPublishers()
        {
            return GetCollection<Publisher>("api/publisher");
        }
    }
}

