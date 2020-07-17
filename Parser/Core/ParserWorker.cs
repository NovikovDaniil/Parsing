using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Html;
using AngleSharp.Html.Parser;

namespace Parser.Core
{

    class ParserWorker<T> where T : class
    {
        IParserSettings parserSettings;
        HtmlLoader loader;

        #region Properties

        public event Action<object, T> OnNewData;   //возвращает спаршенные из итерации данные
        public event Action<object> OnCompleted;    //информирует о завершении работы парсера
        public IParser<T> Parser { get; set; }

        public IParserSettings ParserSettings
        {
            get => parserSettings;
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive { get; private set; }
        #endregion
        public ParserWorker(IParser<T> parser)
        {
            this.Parser = parser;
        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        /// <summary>
        /// начало работы парсера
        /// </summary>
        public void Start()
        {
            IsActive = true;
            Worker();
        }

        /// <summary>
        /// остановка работы парсера
        /// </summary>
        public void Abort()
        {
            IsActive = false;
        }

        /// <summary>
        /// контроль работы парсинга
        /// </summary>
        private async void Worker()
        {
            for (int i = ParserSettings.StartPoint; i <= ParserSettings.EndPoint; i++)
            {
                if (!IsActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var result=Parser.Parse(document);

                OnNewData?.Invoke(this, result);
            }
            OnCompleted?.Invoke(this);
            IsActive = true;
        }
    }
}
