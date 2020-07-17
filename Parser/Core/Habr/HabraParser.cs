using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html.Dom;

namespace Parser.Core.Habr
{
    class HabraParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            //получаем из html документа теги определенного типа
            //проверяем на наличие class и соответствующее название
            var items = document.QuerySelectorAll("a")
                .Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"));

            var list = new List<string>();
            foreach (var item in items)
                list.Add(item.TextContent);

            return list.ToArray();
        }
    }
}
