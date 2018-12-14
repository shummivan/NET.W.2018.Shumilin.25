using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Helpers
{
    /// <summary>
    /// Class for storing pagination information
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Page number
        /// </summary>
        public int PageNumber { get; set; }
        /// <summary>
        /// Page size
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// Items count
        /// </summary>
        public int TotalItems { get; set; }
        /// <summary>
        /// Pages count
        /// </summary>
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
        }
    }

    public class IndexViewModel
    {
        public List<MvcAccount> Brands { get; set; }
        public Pagination PageInfo { get; set; }
    }

    /// <summary>
    /// Create pagination
    /// </summary>
    public static class PagingSubmit
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Pagination pageInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= pageInfo.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                // если текущая страница, то выделяем ее,
                // например, добавляя класс
                if (i == pageInfo.PageNumber)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}