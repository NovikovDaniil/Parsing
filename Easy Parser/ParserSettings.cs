using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Easy_Parser
{
    class ParserSettings
    {
        public string Url { get; set; }
        public Regex Regex { get; set; }
    }
}
