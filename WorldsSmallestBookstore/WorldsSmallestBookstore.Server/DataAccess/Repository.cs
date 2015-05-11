using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldsSmallestBookstore.Models;

namespace WorldsSmallestBookstore.Server.DataAccess
{
    public class Repository
    {
        public static Repository GlobalInstance { get { return _globalInstance.Value; } }

        private static Lazy<Repository> _globalInstance = new Lazy<Repository>(() => { return new Repository(); });

        public BookstoreEntities Data { get { return _data.Value; } }
        private Lazy<BookstoreEntities> _data = new Lazy<BookstoreEntities>(() => { return new BookstoreEntities(); });
    }
}