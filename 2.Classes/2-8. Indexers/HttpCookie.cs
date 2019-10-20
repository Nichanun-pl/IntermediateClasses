using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get {}
            set {}
        }
    }
}
