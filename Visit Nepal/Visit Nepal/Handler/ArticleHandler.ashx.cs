using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
//using App_Code.JsonResponse;

namespace Visit_Nepal.Handler
{
    /// <summary>
    /// Summary description for ArticleHandler
    /// </summary>
    public class ArticleHandler : IHttpHandler, IRequiresSessionState
    {
        protected string Case = "";
        string MethodName = string.Empty;
        string CallBackMethodName = string.Empty;
        object data = string.Empty;

        public void ProcessRequest(HttpContext context)
        {
            try
            {
                context.Response.ContentType = "application/x-javascript";
                MethodName = context.Request.Params["method"];
                data = context.Request.Params["data"];
                CallBackMethodName = context.Request.Params["callbackmethod"];
                switch (MethodName.ToLower())
                {
                    case "addarticle":
                        // context.Response.Write(AddArticle(context));
                        break;
                    case "getarticle":
                        context.Response.Write(GetArticle(context));
                        break;
                    case "deletearticle":
                        // context.Response.Write(DeleteArticle(context));
                        break;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string GetArticle(HttpContext context)
        {
            JsonResponse _response = new JsonResponse();
            System.Web.Script.Serialization.JavaScriptSerializer jSearializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            return "";
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}