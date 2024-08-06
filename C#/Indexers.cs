using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dic;

        public HttpCookie()
        {
            _dic = new Dictionary<string, string>();
        }

        public string this[string key]
        { 
            get { return _dic[key]; }
            set { _dic[key] = value; }
        }


    }
}
