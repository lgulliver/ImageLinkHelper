using System.Web.Mvc;
using System.Web.Routing;

public static class ImageExtensions
{
    public static MvcHtmlString ImageLink(this HtmlHelper html, string action, string controller, object routeValues, string imageURL, string hoverImageURL, string alternateText, object linkHtmlAttributes, object imageHtmlAttributes)
    {
        // Create an instance of UrlHelper
        UrlHelper url = new UrlHelper(html.ViewContext.RequestContext);
        // Create image tag builder
        TagBuilder imageBuilder = new TagBuilder("img");
        // Add image attributes
        imageBuilder.MergeAttribute("src", imageURL);
        imageBuilder.MergeAttribute("alt", alternateText);
        imageBuilder.MergeAttribute("title", alternateText);

        //support for hover
        imageBuilder.MergeAttribute("onmouseover", "this.src='" + hoverImageURL + "'");
        imageBuilder.MergeAttribute("onmouseout", "this.src='" + imageURL + "'");
        imageBuilder.MergeAttribute("border", "0");

        imageBuilder.MergeAttributes(new RouteValueDictionary(imageHtmlAttributes));
        // Create link tag builder
        TagBuilder linkBuilder = new TagBuilder("a");
        // Add attributes
        linkBuilder.MergeAttribute("href", url.Action(action, controller, new RouteValueDictionary(routeValues)));
        linkBuilder.InnerHtml = imageBuilder.ToString(TagRenderMode.SelfClosing);
        linkBuilder.MergeAttributes(new RouteValueDictionary(linkHtmlAttributes));
        // Render tag
        return MvcHtmlString.Create(linkBuilder.ToString(TagRenderMode.Normal));
    }
    public static MvcHtmlString ImageLink(this HtmlHelper html, string action, string controller, string imageURL, string alternateText)
    {
        return ImageLink(html, action, controller, null, imageURL, null, alternateText, null, null);
    }
    public static MvcHtmlString ImageLink(this HtmlHelper html, string action, string controller, object routeValues, string imageURL, string alternateText)
    {
        return ImageLink(html, action, controller, routeValues, imageURL, null, alternateText, null, null);
    }
    public static MvcHtmlString ImageLink(this HtmlHelper html, string action, string controller, object routeValues, string imageURL, string hoverImageURL, string alternateText)
    {
        return ImageLink(html, action, controller, routeValues, imageURL, hoverImageURL, alternateText, null, null);
    }
    public static MvcHtmlString ImageLink(this HtmlHelper html, string action, string controller, string imageURL, string hoverImageURL, string alternateText)
    {
        return ImageLink(html, action, controller, null, imageURL, hoverImageURL, alternateText, null, null);
    }
}
