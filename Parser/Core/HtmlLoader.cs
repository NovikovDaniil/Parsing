using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Parser.Core
{

    /// <summary>
    /// предназначен для загрузки кода страницы из указанных настроек парсера
    /// </summary>
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();

            //построение ссылки
            url = $"{settings.BaseUrl}{settings.Prefix}/";
        }

        /// <summary>
        /// получение кода страницы
        /// </summary>
        /// <param name="pageId"></param>
        /// <returns>
        /// код запрашиваемой страницы
        /// </returns>
        public async Task<string> GetSourceByPageId(int pageId)
        {
            var currentUrl = url.Replace("{CurrentId}", pageId.ToString());
            var response = await client.GetAsync(currentUrl);
            string source = null;   //для получения исходного кода страницы

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
