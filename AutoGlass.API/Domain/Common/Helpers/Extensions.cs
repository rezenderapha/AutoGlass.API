using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AutoGlass.API.Domain.Common.Helpers
{
    public static class Extensions
    {
        public static void AddPagination(this HttpResponse reponse, int currentPage, int itemPerPage, int totalItems, int totalPage)
        {
            var paginationHeader = new PaginationHeader(currentPage, itemPerPage, totalItems, totalPage);
            var camelCase = new JsonSerializerSettings();
            camelCase.ContractResolver = new CamelCasePropertyNamesContractResolver();

            reponse.Headers.Add("Pagination",JsonConvert.SerializeObject(paginationHeader,camelCase));
            reponse.Headers.Add("Access-Control-Expose-Header","Pagination");
        }
    }
}
