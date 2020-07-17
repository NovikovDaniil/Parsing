using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    /// <summary>
    /// настройки парсера
    /// </summary>
    interface IParserSettings
    {
        string BaseUrl { get; set; }    //url сайта для парсинга
        string Prefix { get; set; }
        int StartPoint { get; set; }    //начальная страница для парсинга
        int EndPoint { get; set; }  //конеяная страница для парсинга
    }
}
