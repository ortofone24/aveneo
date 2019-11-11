using aveneo.API.Data;
using aveneo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace aveneo.API.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class HttpHeadersAttribute : Attribute, IActionFilter
    {
        private StringValues accept;
        private StringValues acceptEncoding;
        private StringValues acceptLanguage;
        private StringValues connection;
        private StringValues host;
        private StringValues referer;
        private StringValues userAgent;
        private StringValues origin;
        private StringValues dnt;
        private StringValues secFetchSite;
        private StringValues secFetchMode;
        

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var acceptValue = context.HttpContext.Request.Headers.TryGetValue("accept", out accept);
            if (acceptValue == false)
            {
                accept = "[brak]";
            }

            var acceptEncodingValue = context.HttpContext.Request.Headers.TryGetValue("accept-encoding", out acceptEncoding);
            if (acceptEncodingValue == false)
            {
                acceptEncoding = "[brak]";
            }

            var acceptLanguageValue = context.HttpContext.Request.Headers.TryGetValue("accept-language", out acceptLanguage);
            if (acceptLanguageValue == false)
            {
                acceptLanguage = "[brak]";
            }

            var connectionValue = context.HttpContext.Request.Headers.TryGetValue("connection", out connection);
            if (connectionValue == false)
            {
                connection = "[brak]";
            }

            var hostValue = context.HttpContext.Request.Headers.TryGetValue("host", out host);
            if (hostValue == false)
            {
                host = "[brak]";
            }

            var refererValue = context.HttpContext.Request.Headers.TryGetValue("referer", out referer);
            if (refererValue == false)
            {
                host = "[brak]";
            }

            var userAgentValue = context.HttpContext.Request.Headers.TryGetValue("user-agent", out userAgent);
            if (userAgentValue == false)
            {
                userAgent = "[brak]";
            }

            var originValue = context.HttpContext.Request.Headers.TryGetValue("origin", out origin);
            if (originValue == false)
            {
                origin = "[brak]";
            }

            var dntValue = context.HttpContext.Request.Headers.TryGetValue("dnt", out dnt);
            if (dntValue == false)
            {
                dnt = "[brak]";
            }

            var secFetchSiteValue = context.HttpContext.Request.Headers.TryGetValue("sec-fetch-site", out secFetchSite);
            if (secFetchSiteValue == false)
            {
                secFetchSite = "[brak]";
            }

            var secFetchModeValue = context.HttpContext.Request.Headers.TryGetValue("sec-fetch-mode", out secFetchMode);
            if (secFetchModeValue == false)
            {
                secFetchMode = "[brak]";
            }

            var resultHttpUrl = context.HttpContext.Request.Path.ToString();

            var newHttpHeader = new HttpHeaders
            {
                LoginDate = DateTime.Now,
                Accept = accept,
                AcceptEncoding = acceptEncoding,
                AcceptLanguage = acceptLanguage,
                Connection = connection,
                Host = host,
                Referer = referer,
                UserAgent = userAgent,
                Origin = origin,
                Dnt = dnt,
                SecFetchMode = secFetchMode,
                SecFetchSite = secFetchSite,
                Url = resultHttpUrl
            };

            var db = (DataContext)context.HttpContext.RequestServices.GetService(typeof(DataContext));
            db.HttpHeaders.Add(newHttpHeader);
            db.SaveChanges();
        }
             
    }
}
