using System;
using System.Collections.Generic;
using System.Data;

namespace indexers
{
    public class HttpCookie
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime ExpiryTime { get; set; }

        public HttpCookie()
        {
            
        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
    }
}