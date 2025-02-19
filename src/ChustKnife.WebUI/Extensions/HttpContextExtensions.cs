using ChustKnife.Application.Common.Models;
using Newtonsoft.Json;

namespace ChustKnife.WebUI.Extensions;

public static class HttpContextExtensions
{
    public static void AddPaginationMetaData(this HttpContext httpContext, PaginationInfo paginationInfo)
    {
        if (paginationInfo is null) return;

        var json = JsonConvert.SerializeObject(paginationInfo);

        httpContext.Response.Headers.Remove("X-Pagination");
        httpContext.Response.Headers?.Add("X-Pagination", json);
    }
}