using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core.Habr
{
    class HabraSettings : IParserSettings
    {
        public HabraSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habr.com/ru/";
        public string Prefix { get; set; } = "page{CurrentId}"; //для возможности парсить несколько страниц сайта
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
