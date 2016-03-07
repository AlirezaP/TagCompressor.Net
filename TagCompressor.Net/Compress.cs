
using System.Text;
using System.Web.Mvc;


namespace TagCompressor.Net
{
    public class Compress : ActionFilterAttribute
    {
        private System.Web.UI.HtmlTextWriter tw;
        private System.IO.StringWriter sw;
        private StringBuilder sb;
        private System.Web.HttpWriter output;


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            sb = new StringBuilder();
            sw = new System.IO.StringWriter(sb);
            tw = new System.Web.UI.HtmlTextWriter(sw);
            output = (System.Web.HttpWriter)filterContext.RequestContext.HttpContext.Response.Output;
            filterContext.RequestContext.HttpContext.Response.Output = tw;

            base.OnActionExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string response = sb.ToString();
            response = HtmlCompressor.Compress(response);
            output.Write(response);
        }

    }
}
